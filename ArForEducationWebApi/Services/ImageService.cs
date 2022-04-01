﻿using ArForEducationWebApi.Data;
using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Dto.Image;
using ArForEducationWebApi.Services.Interfaces;
using AutoMapper;

namespace ArForEducationWebApi.Services;

public class ImageService : IImageService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public ImageService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public IEnumerable<Image> GetAll()
    {
        return _unitOfWork.ImageRepository.GetAll().ToList();
    }

    public async Task<Image> CreateAsync(CreateImageDto input)
    {
        var newImage = _mapper.Map<Image>(input);
        newImage = await _unitOfWork.ImageRepository.InsertAsync(newImage);
        await _unitOfWork.SaveAsync();
        return newImage;
    }
}
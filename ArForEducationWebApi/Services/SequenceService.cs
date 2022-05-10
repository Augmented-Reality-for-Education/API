﻿using ArForEducationWebApi.Data;
using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Dto.Sequence;
using ArForEducationWebApi.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ArForEducationWebApi.Services;

public class SequenceService : ISequenceService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public SequenceService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateSequenceDto input)
    {
        if (input.Images != null)
        {
            var newSequence = _mapper.Map<Sequence>(input);
            await _unitOfWork.SequenceRepository.InsertAsync(newSequence);
            await _unitOfWork.SaveAsync();
        }
    }

    public IEnumerable<Sequence> GetAll()
    {
        return _unitOfWork.SequenceRepository.GetAll();
    }
}
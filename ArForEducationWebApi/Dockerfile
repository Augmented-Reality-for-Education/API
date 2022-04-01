FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ArForEducationWebApi/ArForEducationWebApi.csproj", "ArForEducationWebApi/"]
RUN dotnet restore "ArForEducationWebApi/ArForEducationWebApi.csproj"
COPY . .
WORKDIR "/src/ArForEducationWebApi"
RUN dotnet build "ArForEducationWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ArForEducationWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ArForEducationWebApi.dll"]

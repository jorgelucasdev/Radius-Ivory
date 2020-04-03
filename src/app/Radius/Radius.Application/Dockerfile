#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Radius.Application/Radius.Application.csproj", "Radius.Application/"]
COPY ["Radius.Service/Radius.Service.csproj", "Radius.Service/"]
COPY ["Radius.Domain/Radius.Domain.csproj", "Radius.Domain/"]
COPY ["Radius.Infra.CrossCutting.Bus/Radius.Infra.CrossCutting.Bus.csproj", "Radius.Infra.CrossCutting.Bus/"]
COPY ["Radius.Data/Radius.Data.csproj", "Radius.Data/"]
COPY ["Radius.Infra.CrossCutting.IoC/Radius.Infra.CrossCutting.IoC.csproj", "Radius.Infra.CrossCutting.IoC/"]
RUN dotnet restore "Radius.Application/Radius.Application.csproj"
COPY . .
WORKDIR "/src/Radius.Application"
RUN dotnet build "Radius.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Radius.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Radius.Application.dll"]
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ARMApi/ARMApi.csproj", "ARMApi/"]
RUN dotnet restore "ARMApi/ARMApi.csproj"
COPY . .
WORKDIR "/src/ARMApi"
RUN dotnet build "ARMApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ARMApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ARMApi.dll"]
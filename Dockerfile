# Base stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["GBCV.csproj", "."]
RUN dotnet restore "GBCV.csproj"
COPY . .
RUN dotnet build "GBCV.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "GBCV.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GBCV.dll"]
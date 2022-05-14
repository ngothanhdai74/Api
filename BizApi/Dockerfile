#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BizApi/BizApi.csproj", "BizApi/"]
RUN dotnet restore "BizApi/BizApi.csproj"
COPY . .
WORKDIR "/src/BizApi"
RUN dotnet build "BizApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BizApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BizApi.dll"]
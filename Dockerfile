# 使用 .NET 8 SDK 构建项目
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# 复制并还原依赖
COPY gomokuLiveGame.csproj ./
RUN dotnet restore gomokuLiveGame.csproj

# 复制源代码并发布
COPY . ./
RUN dotnet publish gomokuLiveGame.csproj -c Release -o /out

# 使用 .NET 8 运行时运行发布结果
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out .

EXPOSE 18080
ENV ASPNETCORE_URLS=http://+:18080
ENTRYPOINT ["dotnet", "gomokuLiveGame.dll"]

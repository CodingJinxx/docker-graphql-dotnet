FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY server/*.csproj ./server/
COPY data/*.csproj ./data/
RUN dotnet restore

# copy everything else and build app
COPY server/. ./server/
COPY data/. ./data/
WORKDIR /app/server
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=build /app/server/out ./
ENTRYPOINT ["dotnet", "server.dll"]
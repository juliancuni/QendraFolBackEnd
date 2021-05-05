# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:latest AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ./*.csproj ./
RUN dotnet restore

# copy everything else and build app
COPY . ./
WORKDIR /source
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:latest
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "QendraFolApi.dll"]
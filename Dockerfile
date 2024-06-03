# Install the .NET SDK for the build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copy csproj and restore dependencies
COPY back/olegity/olegity.csproj .
RUN dotnet restore olegity.csproj

# Copy the rest of the files and assemble the project
COPY back/olegity .
RUN dotnet publish olegity.csproj -c Release -o /app

# Install the runtime and copy the built application
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .

# Specify the command to run the application
ENTRYPOINT ["dotnet", "olegity.dll"]

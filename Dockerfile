# Get base SDK Image from  Microsoft
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

# copy csproj and restore any dependencies (via NUGET)
COPY *.csproj ./
# COPY aspnetapp/*.csproj ./aspnetapp/
RUN dotnet restore

# copy everything else and build our release
COPY . ./
# WORKDIR /app/aspnetapp
RUN dotnet publish -c Release -o out

#Generate runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
EXPOSE 80
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "ColorAPI.dll"]

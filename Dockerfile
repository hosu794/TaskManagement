# U¿ywamy obrazu SDK do budowy
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Kopiujemy pliki projektu i przywracamy zale¿noœci
COPY *.sln .
COPY API/*.csproj ./API/
COPY Core/*.csproj ./Core/
COPY Data/*.csproj ./Data/
RUN dotnet restore

# Kopiujemy resztê kodu
COPY . ./

# Budujemy i publikujemy
RUN dotnet publish -c Release -o out

# Budujemy obraz runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "API.dll"]
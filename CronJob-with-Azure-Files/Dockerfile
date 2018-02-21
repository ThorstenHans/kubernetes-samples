FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

COPY ./CronSample/*.csproj ./
RUN dotnet restore

# copy everything else and build
COPY ./CronSample/ ./
RUN dotnet publish -c Release -o out

# build runtime image
FROM microsoft/dotnet:runtime
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT ["dotnet", "CronSample.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /src
EXPOSE 5000
EXPOSE 5001
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src/
COPY . .
RUN dotnet publish "/src/ECom.Web/ECom.Web.csproj" --os linux --no-self-contained /p:TrimUnusedDependencies=true -c Release -o /app/publish
COPY ["ECom.Web/app.db", "/app/publish/"]

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT [ "dotnet", "ECom.Web.dll" ]
# ENTRYPOINT [ "bash" ]




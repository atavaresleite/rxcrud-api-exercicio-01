FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY *.sln ./
COPY RXCrud.Api/*.csproj ./RXCrud.Api/
COPY RXCrud.CrossCutting/*.csproj ./RXCrud.CrossCutting/
COPY RXCrud.Domain/*.csproj ./RXCrud.Domain/
COPY RXCrud.NUnitTest/*.csproj ./RXCrud.NUnitTest/
COPY RXCrud.Repositorie/*.csproj ./RXCrud.Repositorie/
COPY RXCrud.Service/*.csproj ./RXCrud.Service/
RUN dotnet restore

COPY RXCrud.Api/. ./RXCrud.Api/
COPY RXCrud.CrossCutting/. ./RXCrud.CrossCutting/
COPY RXCrud.Domain/. ./RXCrud.Domain/
COPY RXCrud.NUnitTest/. ./RXCrud.NUnitTest/
COPY RXCrud.Repositorie/. ./RXCrud.Repositorie/
COPY RXCrud.Service/. ./RXCrud.Service/

WORKDIR /app/RXCrud.Api
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /app/RXCrud.Api/out .

CMD ASPNETCORE_URLS=http://*:$PORT dotnet RXCrud.Api.dll
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Hack-a-thon/Hack-a-thon.csproj", "Hack-a-thon/"]
RUN dotnet restore "Hack-a-thon/Hack-a-thon.csproj"
COPY . .
WORKDIR "/src/Hack-a-thon"
RUN dotnet build "Hack-a-thon.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hack-a-thon.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hack-a-thon.dll"]
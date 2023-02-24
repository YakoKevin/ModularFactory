#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./ModularFactoryAPI", "./ModularFactoryAPI"]
COPY ["./SharedModels", "./SharedModels"]
RUN dotnet restore "./ModularFactoryAPI/ModularFactoryAPI.csproj"
#COPY . .
RUN dotnet build "./ModularFactoryAPI/ModularFactoryAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./ModularFactoryAPI/ModularFactoryAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY ["./ModularFactoryAPI/SvgFiles", "./SvgFiles"]
RUN sed -i 's/TLSv1.2/TLSv1.0/g' /etc/ssl/openssl.cnf
ENTRYPOINT ["dotnet", "ModularFactoryAPI.dll"]

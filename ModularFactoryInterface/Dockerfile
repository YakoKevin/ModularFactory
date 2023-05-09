FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim AS build-env
WORKDIR /src
COPY ./ .
RUN dotnet publish -c Release -o output

FROM nginx:alpine
WORKDIR /var/www/web
COPY --from=build-env /src/output/wwwroot .
COPY ./ModularFactoryInterface/nginx.conf /etc/nginx/nginx.conf
EXPOSE 80
EXPOSE 1990

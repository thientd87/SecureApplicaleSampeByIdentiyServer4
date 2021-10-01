FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SecureApplicationExample.IdentityServer4/SecureApplicationExample.IdentityServer4.csproj", "SecureApplicationExample.IdentityServer4/"]
RUN dotnet restore "SecureApplicationExample.IdentityServer4/SecureApplicationExample.IdentityServer4.csproj"
COPY . .
WORKDIR "/src/SecureApplicationExample.IdentityServer4"
RUN dotnet build "SecureApplicationExample.IdentityServer4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SecureApplicationExample.IdentityServer4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SecureApplicationExample.IdentityServer4.dll"]

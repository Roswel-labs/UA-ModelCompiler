FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Opc.Ua.ModelCompiler/Opc.Ua.ModelCompiler.csproj", "Opc.Ua.ModelCompiler/"]
RUN dotnet restore "Opc.Ua.ModelCompiler/Opc.Ua.ModelCompiler.csproj"
COPY . .
WORKDIR "/src/Opc.Ua.ModelCompiler"
RUN dotnet build "Opc.Ua.ModelCompiler.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Opc.Ua.ModelCompiler.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Opc.Ua.ModelCompiler.dll"]

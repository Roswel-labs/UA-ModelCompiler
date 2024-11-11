FROM mcr.microsoft.com/dotnet/runtime:8.0-jammy AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0-jammy AS build
WORKDIR /src
COPY ["Tests/DemoModel/DemoModel.csproj", "Tests/DemoModel/"]
ENV DOTNET_EnableWriteXorExecute=0
RUN dotnet restore "Tests/DemoModel/DemoModel.csproj"
COPY . .

WORKDIR "/src/Tests/DemoModel"
ARG Version
ARG SimpleVersion
ARG InformationalVersion
ENV OPTIONS="-c Release -f net8.0 -p:NoHttps=true -p:Dockerbuild=true -p:Version=${Version} -p:AssemblyVersion=${SimpleVersion} -p:FileVersion=${Version} -p:InformationalVersion=${InformationalVersion} -p:CustomTestTarget=net8.0"

FROM build AS publish
ENV DOTNET_EnableWriteXorExecute=0
RUN dotnet publish "DemoModel.csproj" --no-restore ${OPTIONS} -o /app/publish 

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 62541
ENTRYPOINT ["dotnet", "DemoModel.dll"]

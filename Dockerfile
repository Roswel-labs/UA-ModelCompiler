# Stage 1: Build the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set working directory
WORKDIR /app

# Copy the solution file and restore dependencies
COPY ModelCompiler.sln ./
COPY src/Opc.Ua.ModelCompiler/Opc.Ua.ModelCompiler.csproj src/Opc.Ua.ModelCompiler/
RUN dotnet restore

# Copy the rest of the files and build the project
COPY . .
RUN dotnet build -c Release -o /app/build

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set environment variables for the input and output
ENV INPUT_FILE_PATH="/input/inputfile.xml"
ENV OUTPUT_DIR_PATH="/output"

# Set working directory
WORKDIR /app

# Copy the compiled app from the build stage
COPY --from=build /app/build .

# Set entrypoint to Opc.Ua.ModelCompiler executable with arguments
ENTRYPOINT ["dotnet", "Opc.Ua.ModelCompiler.dll", "compile", "-d2", "/input/inputfile.xml", "-o2", "/output"]

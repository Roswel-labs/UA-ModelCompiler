#!/bin/bash

# Define paths
MODEL_COMPILER_PATH="src/build/bin/Debug/net8.0/Opc.Ua.ModelCompiler"

# Check if the correct number of arguments is provided
if [ "$#" -ne 2 ]; then
  echo "Usage: $0 <input_file> <output_dir>"
  exit 1
fi

INPUT_FILE="$1"
OUTPUT_DIR="$2"

# Check if the Model Compiler exists
if [ ! -f "$MODEL_COMPILER_PATH" ]; then
  echo "Error: Opc.Ua.ModelCompiler not found at $MODEL_COMPILER_PATH"
  exit 1
fi

echo "Starting Opc.Ua.ModelCompiler with input file: $INPUT_FILE"
echo "Output will be saved to: $OUTPUT_DIR"

# Create the output directory if it doesn't exist
mkdir -p "$OUTPUT_DIR"

# Run the Opc.Ua.ModelCompiler with specified parameters
"$MODEL_COMPILER_PATH" compile -d2 "$INPUT_FILE" -o2 "$OUTPUT_DIR"

# Check if the command was successful
if [ $? -eq 0 ]; then
  echo "Model compilation completed successfully!"
else
  echo "Error: Model compilation failed."
  exit 1
fi

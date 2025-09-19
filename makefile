#=============================================================================
# Makefile for a C++ application using wxWidgets and MariaDB Connector/C++.
# This version explicitly lists source directories for a more robust build.
#=============================================================================

# --- Project Configuration ---
# The name of your executable.
EXECUTABLE = wa_direct

# The build and source directories.
BUILD_DIR = build
SRC_DIRS = src src/dlgs src/libs

# Automatically find all C++ source files in the source directory and its subdirectories.
SOURCES = $(foreach dir,$(SRC_DIRS),$(wildcard $(dir)/*.cpp))

# Create a list of object files from the source files, placing them in the build directory.
OBJECTS = $(patsubst %.cpp,$(BUILD_DIR)/%.o,$(notdir $(SOURCES)))

# --- Compiler and Linker Flags ---
# The C++ compiler to use.
CXX = g++

# Use wx-config to get compiler flags and linker libraries for wxWidgets.
WX_CFLAGS := $(shell wx-config --cxxflags --unicode=yes)
WX_LIBS := $(shell wx-config --libs --unicode=yes)

# Final flags for compilation and linking.
CXXFLAGS = $(WX_CFLAGS) -std=c++11 -Wall
LDFLAGS = $(WX_LIBS)

# VPATH tells Make where to find source files.
# This makes it easier for Make to find the dependencies.
VPATH = $(SRC_DIRS)

# --- Build Rules ---
# The default rule. Builds the project by first creating the build directory.
all: $(BUILD_DIR) $(BUILD_DIR)/$(EXECUTABLE)
	@echo "Build complete. Executable is in the 'build' directory."

# Rule to create the build directory if it doesn't exist.
$(BUILD_DIR):
	@mkdir -p $(BUILD_DIR)

# The rule for the final executable. It depends on all object files.
$(BUILD_DIR)/$(EXECUTABLE): $(OBJECTS)
	@echo "Linking..."
	$(CXX) $(OBJECTS) $(LDFLAGS) -o $@
	@echo "Executable created: $@"

# Generic rule to compile a .cpp file into a .o object file.
$(BUILD_DIR)/%.o: %.cpp
	@echo "Compiling $< -> $@"
	@mkdir -p $(@D)
	$(CXX) $(CXXFLAGS) -c $< -o $@

# --- Utility Rules ---
# Clean rule to remove the build directory and its contents.
clean:
	@echo "Cleaning up..."
	@rm -rf $(BUILD_DIR)
	@echo "Done."

# Run rule to execute the program from the build directory.
run: all
	@echo "Running the application..."
	./$(BUILD_DIR)/$(EXECUTABLE)

.PHONY: all clean run

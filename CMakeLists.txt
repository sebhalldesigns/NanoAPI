cmake_minimum_required(VERSION 3.10)

# Set the project name
project(NanoAPI)

#set(CMAKE_EXE_LINKER_FLAGS "-static")

# Add an executable
add_library(NanoAPI SHARED
    lib/NanoAPI.c
)

target_include_directories(NanoAPI PRIVATE
    lib
)

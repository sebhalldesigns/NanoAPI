#include "NanoAPI.h"

#include <stdio.h>  

const char* g_systemTypes[] = {
    "NObject",
};

void NanoApi_Init()
{
    printf("NanoApi_Init\n");
}

bool NanoApi_GetSystemType(const char* typeName, nType_ptr* outPtr)
{
    printf("NanoApi_GetSystemType: %s\n", typeName);
    *outPtr = 69;
    return true;
}

bool NanoApi_DeclareCustomType(const char* typeName, const char* baseTypeName, nType_ptr* outPtr)
{
    printf("NanoApi_DeclareCustomType: %s: %s\n", typeName, baseTypeName);
    *outPtr = 420;
    return true;
}

bool NanoApi_AddParameter(const char* targetName, const char* name, const char* typeName, nParameter_ptr* outPtr)
{
    printf("NanoApi_AddParameter: %s: %s: %s\n", targetName, name, typeName);
    *outPtr = 1337;
    return true;
}

bool NanoApi_DeclareInstance(const char* typeName, nType_ptr* outPtr)
{
    printf("NanoApi_DeclareInstance: %s\n", typeName);
    *outPtr = 666;
    return true;
}
#ifndef NANOAPI_H   
#define NANOAPI_H

#include <stdint.h>
#include <stdbool.h>

typedef uintptr_t nType_ptr;
typedef uintptr_t nParameter_ptr;
typedef uintptr_t nMethod_ptr;

typedef struct nParameter
{
    const char* name;
    nType_ptr type;
} nParameter;

typedef struct nMethod
{
    const char* name;
    
    size_t parameterCount;
    nParameter_ptr parameters;

    nType_ptr returnType;
} nMethod;

typedef struct nType
{
    const char* name;
    
    size_t parameterCount;
    nParameter_ptr parameters;

    size_t methodCount;
    nMethod_ptr methods;

    nType_ptr baseType;
} nType;

void NanoApi_Init();

bool NanoApi_GetSystemType(const char* typeName, nType_ptr* outPtr);

bool NanoApi_DeclareCustomType(const char* typeName, const char* baseTypeName, nType_ptr* outPtr);
bool NanoApi_AddParameter(const char* targetName, const char* name, const char* typeName, nParameter_ptr* outPtr);

bool NanoApi_DeclareInstance(const char* typeName, nType_ptr* outPtr);

//bool NanoApi_AddMethod(nType_ptr targetType, const char* name, nType_ptr returnType, size_t parameterCount, nParameter_ptr parameters);

#endif // NANOAPI_H
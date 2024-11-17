#ifndef NANOAPI_H   
#define NANOAPI_H

#include <stdint.h>

typedef enum
{
    SCALAR_TYPE_BOOL8   = 0x0,
    SCALAR_TYPE_UINT8   = 0x1,
    SCALAR_TYPE_INT8    = 0x2,
    SCALAR_TYPE_UINT16  = 0x3,
    SCALAR_TYPE_INT16   = 0x4,
    SCALAR_TYPE_UINT32  = 0x5,
    SCALAR_TYPE_INT32   = 0x6,
    SCALAR_TYPE_UINT64  = 0x7,
    SCALAR_TYPE_INT64   = 0x8,
    SCALAR_TYPE_FLOAT32 = 0x9,
    SCALAR_TYPE_FLOAT64 = 0xA
} nApiScalarType;



typedef struct 
{
    const char* name;
} nApiMethod;

typedef struct 
{
    uintptr_t length; 
    const void* data;
} nApiBuffer;

void NANOAPI_TX(nApiBuffer buffer);
nApiBuffer NANOAPI_RX();
void NANOAPI_CLK();

#endif // NANOAPI_H
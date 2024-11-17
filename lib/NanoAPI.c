#include "NanoAPI.h"

#include <stdio.h>  

void NANOAPI_TX(nApiBuffer buffer)
{
    printf("NANOAPI_TX\n");
}
nApiBuffer NANOAPI_RX()
{
    printf("NANOAPI_RX\n");
    nApiBuffer buffer;
    return buffer;
}
void NANOAPI_CLK()
{
    printf("NANOAPI_CLK\n");
}
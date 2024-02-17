#include <stdio.h>

int main()
{       
    for (int i = 1; i <= 5; i++) // 1번
    {        
        for (int j = 1; j <= i; j++)
        {
            printf("*");            
        }
        printf("\n");
    }
    printf("\n");

    for (int i = 1; i <= 5; i++) // 2번
    {
        for (int j = 1; j <= 2 * i - 1; j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n");

    for (int i = 5; i >= 1; i--) // 3번
    {
        for (int j = 1; j <= i; j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n");

    for (int i = 1; i <= 5; i++) // 4번
    {
        for (int j = 1; j <= 5 - i; j++) 
        {
            printf(" ");
        }
        for (int j = 1; j <= i; j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n");

    for (int i = 1; i <= 5; i++) // 5번
    {
        for (int j = 1; j <= 5 - i; j++)
        {
            printf(" ");
        }
        for (int j = 1; j <= 2 * i - 1; j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n");

    for (int i = 5; i >= 1; i--) // 6번
    {
        for (int j = 1; j <= 5-i; j++)
        {
            printf(" ");
        }
        for (int j = 1; j <= 2 * i - 1; j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n");
}
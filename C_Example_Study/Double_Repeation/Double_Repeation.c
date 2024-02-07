#include <stdio.h>

int main()
{
    // * 을 5줄 출력
    // * 이 줄바꿈마다 1개씩 증가
     
    for (int i = 1; i <= 5; i++)
    {        
        for (int j = 1; j <= i; j++)
        {
            printf("*");            
        }
        printf("\n");
    }
    printf("\n");

    for (int i = 1; i <= 5; i++)
    {
        for (int j = 1; j <= 2 * i - 1; j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n");

    for (int i = 1; i <= 5; i++)
    {
        for (int j = 0; j < 6 - i; j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n");

    for (int i = 0; i <= 5; i++)
    {
        
    }

}
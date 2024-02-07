#include <stdio.h>

// 커피가격을 enum을 통해 출력하기
// 아메리카노 short 3800 tall 4100 grande 4600 venti 5100
// 카푸치노 4600 5900 6400 6900

enum Size {Short, Tall, Grande, Venti};
char size_name[][7] = { "Short", "Tall", "Grande", "Venti" };
int price_Americano[] = { 3800, 4100, 4600, 5100 };
int price_Cappuccino[] = { 4600, 5900, 6400, 6900 };

int main() 
{
    printf("아메리카노\n");
    for (int i = Short; i <= Venti; i++)
    {
        printf("%7s : %5d원\n", size_name[i], price_Americano[i]);
    }
    printf("\n");

    printf("카푸치노\n");
    for (int i = Short; i <= Venti; i++)
    {
        printf("%7s : %5d원\n", size_name[i], price_Cappuccino[i]);
    }
}
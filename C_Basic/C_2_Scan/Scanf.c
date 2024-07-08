#include <stdio.h>

int main(void)
{
    //문제 1
    int Num1, Num2;
    printf("뺄셈과 곱셈의 결과를 출력할 정수 두 개를 입력하세요 : ");
    scanf("%d %d", &Num1, &Num2);
    int result1 = Num1 - Num2;
    int result2 = Num1 * Num2;
    printf("%d - %d = %d\n", Num1, Num2, result1);
    printf("%d * %d = %d\n", Num1, Num2, result2);
    
    //문제 2
    int num1, num2, num3;
    printf("세 개의 정수를 입력하세요 : ");
    scanf("%d %d %d", &num1, &num2, &num3);
    int result3 = num1 * num2 + num3;
    printf("%d X %d + %d = %d\n", num1, num2, num3, result3);

    //문제 3
    int Sq_num;
    printf("제곱의 결과를 출력할 정수를 입력하세요 : ");
    scanf("%d", &Sq_num);
    int Square = Sq_num * Sq_num;
    printf("%d의 제곱은 %d입니다.\n", Sq_num, Square);

    //문제 4
    int dividend, divisor;
    printf("나눗셈을 실행할 두 정수를 입력하세요 : ");
    scanf("%d %d", &dividend, &divisor);
    int quo = dividend / divisor;
    int rem = dividend % divisor;
    printf("몫 : %d, 나머지 : %d\n", quo, rem);

    //문제 5
    int NUM1, NUM2, NUM3;
    printf("정수 세 개를 입력하세요 : ");
    scanf("%d %d %d", &NUM1, &NUM2, &NUM3);
    int result4 = (NUM1 - NUM2) * (NUM2 + NUM3) * (NUM3 % NUM1);
    printf("결과 : %d", result4);

    return 0;
}
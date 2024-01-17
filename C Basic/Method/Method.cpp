#include <stdio.h>

//int MaxNum(int num1, int num2, int num3)
//{
//    if (num1 > num2)
//        return (num1 > num3) ? num1 : num3;
//    else
//        return (num2 > num3) ? num2 : num3;
//}
//
//int MinNum(int num1, int num2, int num3)
//{
//    if (num1 < num2)
//        return (num1 < num3) ? num1 : num3;
//    else
//        return (num2 < num3) ? num2 : num3;
//}

//double CelToFah(double Celsius)
//{
//    return Celsius * 1.8 + 32;
//}
//
//double FahToCel(double Fahrenhit)
//{
//    return (Fahrenhit - 32) / 1.8;
//}

//void Fibonach(int num)
//{
//    int f1 = 0, f2 = 1, f3;
//
//    if (num == 1)
//    {
//        printf("%d ", f1);
//    }
//    else
//    {
//        printf("%d %d ", f1, f2);
//    }
//
//    for (int i = 0; i < num - 2; i++)
//    {
//        f3 = f1 + f2;
//        printf("%d ", f3);
//        f1 = f2;
//        f2 = f3;
//    }
//}



//int AddToTotal(int num)
//{
//    static int total = 0;
//    total += num;
//    return total;
//}

//void Recursive(int num)
//{
//    if (num <= 0)
//        return;
//    printf("Recursive Call! %d \n",num);
//    Recursive(num-1);
//}

int Factorial(int n)
{
    if (n == 1)
        return 1;
    else
    {
        return n * Factorial(n - 1);
    }
        
}

int main()
{
    /*printf("3과 4와 5중에 가장 큰 수는 %d입니다.\n", MaxNum(3, 4, 5));
    printf("3과 4와 5중에 가장 작은 수는 %d입니다.\n", MinNum(3, 4, 5));*/

    /*int select;
    double Celsius, Fahrenhit;

    printf("1. 섭씨를 화씨로 2. 화씨를 섭씨로 ");
    printf("번호를 선택하세요 : ");
    scanf("%d", &select);

    if (select == 1)
    {
        printf("화씨로 전환할 섭씨온도를 입력하세요. ");
        scanf("%lf", &Celsius);
        printf("섭씨 %f도는 화씨로 %f도입니다.\n", Celsius, CelToFah(Celsius));
    }
    else if (select == 2)
    {
        printf("섭씨로 전환할 화씨온도를 입력하세요. ");
        scanf("%lf", &Fahrenhit);
        printf("화씨 %f도는 섭씨로 %f도입니다.\n", Fahrenhit, CelToFah(Fahrenhit));
    }*/
    /*int num;
    printf("출력한 피보나치 수열의 갯수를 입력하세요.");
    scanf("%d", &num);

    if (num < 1)
    {
        printf("1 이상의 수를 입력해주세요.");
        return -1;
    }

    Fibonach(num);*/

    /*int num, i;
    for (i = 0; i < 3; i++)
    {
        printf("입력%d : ", i + 1);
        scanf("%d", &num);
        printf("누적 : %d\n", AddToTotal(num));
    }*/
    
    /*Recursive(3);*/

    /*int num;
    printf("출력할 계승의 수를 입력하세요.");
    scanf("%d", &num);
    if (num <= 0)
        printf("1 이상의 수를 입력해주세요.");
    else
    {
        printf("%d! = %d", num, Factorial(num));

    }
    return 0;*/
}






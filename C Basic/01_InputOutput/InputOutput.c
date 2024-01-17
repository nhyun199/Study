#include <stdio.h>

int main()
{
    //double celsius; // 섭씨온도
    //printf("섭씨온도를 화씨온도로 바꿔주는 프로그램입니다.\n");
    //printf("섭씨온도를 입력해주세요 : ");
    //scanf("%lf", &celsius);

    //printf("섭씨온도 %f도는 화씨온도 %f도 입니다.\n", celsius, 9 * celsius / 5 + 32);
 
    char ch;

    short sh;
    int i;
    long lo;

    float fl;
    double du;
    
    printf("char형 변수 입력 : ");
    scanf("%c", &ch);

    printf("short형 변수 입력 : ");
    scanf("%hd", &sh);
    printf("int형 변수 입력 : ");
    scanf("%d", &i);
    printf("long형 변수 입력 : ");
    scanf("%ld", &lo);

    printf("float형 변수 입력 :");
    scanf("%f", &fl);
    printf("double형 변수 입력");
    scanf("%lf", &du);
        
    printf("char : %c, short : %hd, int : %d, long : %ld\n", ch, sh, i, lo);
    printf("float : %f, double : %f ", fl, du);

    return 0;
}


// 문자 정수 실수
// 문자 char, 정수 short / int  / long, 실수 float / double
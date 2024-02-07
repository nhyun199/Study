#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
    // 반지름이 r인 원 , 넓이 Pi * r^2
    // 원을 둘러싼 정사각형 한 변 2r, 넓이 : 4r^2
    // 사각형 / 원 = 4 / Pi

    int x, y; // 점 x, y
    int icnt = 0; // 원 내부 점의 개수
    int ocnt = 0; // 원 외부 점의 개수
    int rad = 50; // 반지름의 길이
    double pi; // 원주율 -> 이걸 구해야함

    for (int i = 1; i <= 100000000; i++)
    {
        x = rand() % 100;
        y = rand() % 100;

        if ((x - rad)*(x - rad) + (y - rad)*(y - rad) <= rad * rad)
        {
            icnt++;
        }
        else
        {
            ocnt++;
        }

        pi = (double)icnt / (icnt + ocnt) * 4;

        if (i < 10 || i > 99999990)
            printf("i = %d, pi = %.9f\n", i, pi);
    }

}

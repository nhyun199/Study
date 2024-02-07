#include <stdio.h>
#include <stdbool.h>

int main()
{
    bool sign = false; // 조건에 사용할 변수 sign
    double Pi = 0;     // Pi의 값
    
    for (int i = 1; i < 100000000; i += 2)
    {
        if (sign == false)
        {
            Pi += 1.0 / i;
            sign = true;
        }
        else
        {
            Pi -= 1.0 / i;
            sign = false;
        }

        if (i < 20 || i > 99999990) // 모든 결과를 볼 수는 없으므로 보여줄 구간을 설정함
            printf("i = %d, Pi = %.9f\n", i, 4 * Pi);
    }

    
}



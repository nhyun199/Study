#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define CNT 10

int main()
{
	srand(time(0)); // 시드 초기화

	int check[CNT + 1] = { 0 };
	int rand_num[CNT] = { 0 };
	int rand_max = 10;
	int rand_min = 1;
	
	int v = rand_max - rand_min + 1;

	int count = 0;

	while (count != 10)
	{
		rand_num[count] = rand() % v + rand_min; // rand[0] = 랜덤 숫자 배정

		if (check[rand_num[count]] == 0) // 중복이 없는 경우니까 조건문 실행		
			check[rand_num[count++]] = 1; // 중복 체크가 되도록 1로 변경후
	}

	for (int i = 0; i < CNT; i++)
	{
		printf("rand_num[%d] = %d\n", i, rand_num[i]);
	}
}
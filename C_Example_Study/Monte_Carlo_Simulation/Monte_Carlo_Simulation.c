#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#define TRIALS 1000000

int main()
{
	srand(time(0)); // 시드 초기화

	int cnt[13] = { 0 };
	int rand_min = 1;
	int rand_max = 6;
	int dice;
	
	int v = rand_max - rand_min + 1;

	for (int i = 0; i < TRIALS; i++)
	{
		dice = (int)((double)rand() / ((RAND_MAX + 1)) * v + rand_min);
		dice += (int)((double)rand() / ((RAND_MAX + 1)) * v + rand_min); // 두 주사위의 합
		cnt[dice]++;
	}

	int total = 0;
	for (int i = 2; i <= 12; i++)
	{
		printf("cnt[%2d] = %8d, %5.2f%%\n", i, cnt[i], (double)cnt[i] / TRIALS * 100);
		total += cnt[i];
	}
	printf("total = %d\n", total);

}
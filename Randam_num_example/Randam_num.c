#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
	srand(time(0));

	int a[10]; // 난수 생성 테스트 배열
	int Dice[30]; // 주사위를 30번 던졌을 때 나오는 수를 저장할 배열
	int randmax = 6; // 난수의 최대값
	int randmin = 1; // 난수의 최소값

	for (int i = 0; i < 10; i++)
	{
		a[i] = rand();
	}

	printf("RAND_MAX = %x, %d\n", RAND_MAX, RAND_MAX);

	for (int i = 0; i < 10; i++)
	{
		printf("%6d", a[i]);
	}
	printf("\n");

	for (int i = 0; i < 30; i++)
	{
		//Dice[i] = (double)rand() / RAND_MAX * (randmax + randmin - 1) + randmin;
		Dice[i] = (rand() % (randmax - randmin + 1)) + randmin;
	}

	for (int i = 0; i < 30; i++)
	{
		printf("%6d%c", Dice[i], (i + 1) % 10 != 0 ? ' ' : '\n');
	}
}
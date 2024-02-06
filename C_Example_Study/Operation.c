#include <stdio.h>

int main()
{
	// 001 정수를 배열에 저장하고 최소, 최대, 평균 계산하기

	int a[10];
	int min, max;
	int sum = 0;

	for (int i = 0; i < 10; i++)
	{
		printf("%d번째 숫자를 입력하세요.", i + 1);
		scanf("%d", &a[i]);		
	}

	for (int i = 0; i < 10; i++)
	{
		printf("%6d", a[i]);		
	}
	printf("\n");
	
	min = max = a[0];

	for (int i = 0; i < 10; i++)
	{
		sum += a[i];

		if (a[i] < min)
			min = a[i];

		else if (max < a[i])
			max = a[i];
	}
	
	printf("정수의 평균 : %.2f, 정수의 최대값 : %d, 정수의 최소값 : %d", sum / 10.0, max, min);
		
	
	
}
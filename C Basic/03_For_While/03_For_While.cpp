#include <stdio.h>
int main()
{
	for (int i = 0; i < 20; i++)
	{
		printf("%d\n", i);
	}

	int sum = 0;
	for (int i = 0; i < 20; i++)
	{
		sum += i;
	}
	printf("1부터 19까지의 합은 %d입니다.\n", sum);

	
}

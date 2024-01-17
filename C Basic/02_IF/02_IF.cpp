#include <stdio.h>

int main()
{
	/*double i, j;
	printf("나누고 싶은 두 수를 입력하세요 : ");
	scanf("%lf %lf", &i, &j);

	if (j == 0)
	{
		printf("0으로는 나눌 수 없습니다.");
		return 0;
	}
	printf("%f를 %f로 나눈 값은 %f입니다.", i, j, i / j);
	return 0;*/

	int score;
	printf("당신의 점수를 입력하세요 : ");
	scanf("%d", &score);

	if (score >= 90)
	{
		printf("합격");
	}
	else if (score < 90)
	{
		printf("불합격");
	}
	/*else
	{
		printf("불합격");
	}*/

	
	
}

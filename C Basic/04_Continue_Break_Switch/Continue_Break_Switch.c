#include <stdio.h>

int main()
{
	/*int num = 1;
	int sum = 0;

	while (num != 0)
	{
		printf("덧셈을 실행할 정수를 입력하세요 : ");
		scanf("%d", &num);
		sum += num;
	}
	printf("%d", sum);*/ // num을 적절히 초기화해서 사용한 경우

	/*int num = 0;
	int sum = 0;
	printf("정수를 입력하세요 : ");
	scanf("%d", &num);
	sum += num;

	while (num != 0)
	{
		printf("정수를 입력하세요 : ");
		scanf("%d", &num);
		sum += num;
	}

	printf("정수의 합은 %d입니다.", sum);
	return 0;*/

	/*int num = 1;
	int sum = 0;

	do
	{
		sum += num * 2;
		num++;
	} while (num <= 50);

	printf("100까지의 짝수의 합은 %d입니다.", sum);*/

	/*int num = 0;
	int i = 1;
	printf("출력할 구구단의 단 수를 입력하세요 : ");
	scanf("%d", &num);

	do
	{
		printf("%d * %d = %d\n", num, i, num * i);
		i++;
	} while (i < 10);*/

	/*int num1, num2;
	int sum = 0;

	printf("사이의 합을 구할 두 정수를 입력하세요. : ");
	scanf("%d %d", &num1, &num2);

	for (num1; num1 <= num2; num1++)
	{
		sum += num1;
	}
	printf("%d", sum);*/

	// n의 계승 구하기
	/*int num = 0, i = 0;
	int factorial = 1;

	printf("계승을 구할 정수를 입력하세요. ");
	scanf("%d", &num);

	for (i = 1; i <= num; i++)
	{
		factorial = factorial * i;
	}
	printf("%d! = %d\n", num, factorial);
	return 0;*/

	// 1이상 100미만의 정수 중 7의 배수와 9의 배수, 7의 배수이면서 동시에 9의 배수인 정수는 한번만 출력해야함

	/*int i = 0;

	for (i = 1; i < 100; i++)
	{
		if (i % 7 == 0 || i % 9 == 0)
		{
			printf("%d\n", i);
		}
	}*/

	/*int num1, num2;
	int subtract = 0;

	printf("차이를 구할 두 수를 입력하세요. ");
	scanf("%d %d", &num1, &num2);

	if (num1 >= num2)
	{
		printf("두 수의 차는 %d입니다.", num1 - num2);
	}
	else
	{
		printf("두 수의 차는 %d입니다.", num2 - num1);
	}*/

	// 학생의 전체 평균 점수에 대한 학점 출력하기. 국 영 수 점수의 평균 => 학점으로 변환하기

	/*int Korean, English, Math;

	printf("국어, 영어, 수학 점수를 순서대로 입력하세요 :  ");
	scanf("%d %d %d", &Korean, &English, &Math);

	int Average = (Korean + English + Math) / 3;

	if (Average >= 90)
	{
		printf("점수 평균은 %d이며, 학점은 A입니다.", Average);
	}
	else if (Average >= 80)
	{
		printf("점수 평균은 %d이며, 학점은 B입니다.",Average);
	}
	else if (Average >= 70)
	{
		printf("점수 평균은 %d이며, 학점은 C입니다.",Average);
	}
	else if (Average >= 50)
	{
		printf("점수 평균은 %d이며, 학점은 D입니다.", Average);
	}
	else
	{
		printf("점수 평균은 %d이며, 학점은 F입니다.", Average);
	}*/

	/*int sum = 0, num = 0;

	while (1)
	{
		sum += num;
		if (sum > 5000)
			break;
		num++;

	}
	printf("%d\n", sum);
	printf("%d\n", num);*/

	/*int num;

	for (num = 1; num < 20; num++)
	{
		if (num % 2 == 0 || num % 3 == 0)
			continue;
		printf("%d ", num);
	}*/

	// ! @ # $ % ^ & * ( \ ' " < > ? : ;
	// %%

	//printf("! @ # $ %% ^ & * ( \\ ' \" < > ? : ; ");

	/*int i, j;
	for (i = 1; i < 10; i++)
	{
		if (i % 2 != 0)
			continue;

		for (j = 1; j < 10; j++)
		{
			if (i < j)
				break;
			printf("%d X %d = %d\n", i, j, i * j);
		}
		printf("\n");
	}*/

	/*int A, Z;
	int result = 0;

	for (A = 0; A < 10; A++)
	{
		for (Z = 0; Z < 10; Z++)
		{
			if (A == Z)
				continue;

			result = (A * 10 + Z) + (Z * 10 + A);

			if (result == 99)
				printf("%d%d + %d%d = %d\n", A, Z, Z, A, result);
		}
	}*/

	/*int num;
	printf("원하는 정수를 입력하세요 : ");
	scanf("%d", &num);

	switch (num / 10)
	{
	case 0:
		printf("0 이상 10 미만");
		break;
	case 1:
		printf("10 이상 20 미만");
		break;
	case 2:
		printf("20 이상 30 미만");
		break;
	default:
		printf("30 이상");
		break;
	}*/


}
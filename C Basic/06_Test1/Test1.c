#include <stdio.h>

// 도전 2 구구단 함수
//void GuGuDan(int num1, int num2)
//{
//	int i = 0, k = 0;
//	if (num1 >= num2)
//	{
//		i = num2, k = num1;
//	}
//	else
//	{
//		i = num1, k = num2;
//	}
//
//	for (; i <= k; i++)
//	{
//		for (int j = 1; j <= 9; j++)
//		{
//			printf("%d X %d = %d\n", i, j, i * j);
//		}
//		printf("\n");
//	}
//}

// 도전 4 잔돈 남기지 않기 함수

// 도전 5 10개의 소수를 출력하기

int main()
{
	// 도전1 10진수를 입력받아 16진수로 출력하기
	/*int num;
	printf("16진수로 출력할 10진수를 정수를 입력하세요. ");
	scanf("%d", &num);
	printf("%d는 16진수로 %x입니다.", num, num);*/

	// 도전2 두 개의 정수를 입력받아 구구단을 출력하기
	/*int num1, num2;
	printf("정수 두개를 입력하세요. ");
	scanf("%d %d", &num1, &num2);
	GuGuDan(num1, num2);*/

	// 도전3 두 개 정수를 입력받아 최대 공약수를 구하기
	
	// 도전4 잔돈을 남기지 않고 물품 구매하기		
	// 500원, 700원, 400원짜리 물건을 최소 한 개씩 구매
	/*for (int i = 1; i * 500 <= total - 700 - 400; i++) 
	{
		for (int j = 1; j * 700 <= total - 500 * i - 400; j++) 
		{
			for (int k = 1; k * 400 <= total - 500 * i - 700 * j; k++) 
			{
				if (500 * i + 700 * j + 400 * k == total) 
				{					
					printf("500원짜리 %d개, 700원짜리 %d개, 400원짜리 %d개\n", i, j, k);
				}
			}
		}
	}*/


	// 도전 5 10개의 소수를 출력하기
	

	// 도전 6 초를 입력받아 형태 변환하기

	int Second;
	int h, m, s;
	printf("변환할 초를 입력하세요.");
	scanf("%d", &Second);
	h = Second / 3600;
	m = (Second == 0) ? Second / 60 : (Second / 3600 - 3600) / 60;
	printf("[h : ]")
	
}


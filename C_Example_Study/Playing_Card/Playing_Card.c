#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <stdbool.h>
int main() 
{
	// 트럼프 카드 0~51의 숫자를 무늬와 매칭? 
	// 0~12 : 클로버 1~13번 / 13 ~ 25 : 하트 : 1~13번 / 26 ~ 38 : 스페이드 : 1~13번 / 39 ~ 51 : 다이아 : 1~13번

	// card[i] = 0 , 클로버 1 
	// 몫 클 0 하 1 스 2 다 3


	srand(time(0)); // 시드 초기화
	
	int card[52] = { 0 }; // 랜덤한 숫자를 넣을 배열
	int check[52] = { 0 }; // 중복을 체크할 배열
	int rand_max = 51;	
	

	for (int i = 0; i < 52; i++)
	{
		card[i] = rand() % (rand_max + 1);

		if (check[card[i]] == 0) // 중복이 아닐 경우
		{
			check[card[i]] = 1;
		}
		else
		{
			i--;
		}
	}

	// 랜덤 숫자를 13으로 나눴을 때  
	// 몫이 0이고(클로버), 나머지 + 1 if(card[i] / 13 == 0)
	// 몫이 1이고(하트), 나머지 + 1 if(card[i] / 13 == 1)
	// 몫이 2이고(스페이드), 나머지 + 1 if(card[i] / 13 == 2)
	// 몫이 3이고(다이아몬드), 나머지 + 1 if(card[i] / 13 == 3)

	for (int i = 0; i < 52; i++)
	{
		if (card[i] / 13 == 0)
		{
			printf("card[%2d] = %3d,     클로버 %3d\n", i, card[i], card[i] % 13 + 1);
		}

		else if (card[i] / 13 == 1)
		{
			printf("card[%2d] = %3d,       하트 %3d\n", i, card[i], card[i] % 13 + 1);
		}

		else if (card[i] / 13 == 2)
		{
			printf("card[%2d] = %3d,   스페이드 %3d\n", i, card[i], card[i] % 13 + 1);
		}

		else
		{
			printf("card[%2d] = %3d, 다이아몬드 %3d\n", i, card[i], card[i] % 13 + 1);
		}
	}
}
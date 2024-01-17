#include <stdio.h>

void ShowOddNum(int* arr)
{
	printf("홀수 출력: ");
	for (int i = 0; i < 10; i++)
	{
		if(arr[i] % 2 != 0) // 홀수 -> 2로 나누어 나머지가 0이 아닌 수
		printf("%d ", arr[i]);
	}
	printf("\n");
}

void ShowEvenNum(int* arr)
{
	printf("짝수 출력: ");
	for (int i = 0; i < 10; i++)
	{
		if(arr[i] % 2 == 0) // 짝수 -> 2로 나누어 나머지가 0인 수
		printf("%d ", arr[i]);
	}
	printf("\n");
}

void DecimalToBinary(void)
{
	int Decimal;
	int Binary[20] = { 0, };
	int Position = 0;
	printf("10진수 정수 입력: ");
	scanf("%d", &Decimal);
	// Dec를 2로 나눔 => 몫이 0이 나올 때까지
	// 나머지를 거꾸로 정렬함 => 2진수로 변환끝

	while (1)
	{
		Binary[Position] = Decimal % 2;
		Decimal = Decimal / 2;
		Position++;

		if (Decimal == 0)
			break;
	}

	for (int i = Position - 1; i >= 0; i--)
	{
		printf("%d", Binary[i]);
	}	
	printf("\n");
}

void Example3(void)
{	
	int arr[10];
	int SortArr[10];
	int Position = 0;

	for (int i = 0; i < 10; i++)
	{
		printf("입력: ");
		scanf("%d", &arr[i]);
		
		if (arr[i] % 2 != 0)
		{
			SortArr[Position] = arr[i];
			Position++;
		}
	}
	
	for (int i = 9; i >= 0; i--)
	{
		if (arr[i] % 2 == 0)
		{
			SortArr[Position] = arr[i];
			Position++;
		}
	}

	for (int i = 0; i < 10; i++)
	{
		printf("%d ", SortArr[i]);
	}
	printf("\n");
}

void ISPalindrome(char* arr, int len)
{
	char FlipedArr[100];
	int Total = 0;
	
	for (int i = 0; i < len; i++)
	{
		FlipedArr[i] = arr[(len - 1) - i];
	}	
	FlipedArr[len] = '\0';	

	printf("뒤집은 문자열 : %s\n", FlipedArr);

	for (int i = 0; i < len; i++)
	{
		int add = (FlipedArr[i] == arr[i]) ? 0 : 1;
		Total += add;
	}	
	
	if (Total == 0)
		printf("회문 입니다.\n");
	else
		printf("회문이 아닙니다.\n");
}

void BubbleSort(int arr[], int len)
{
	int temp = 0;

	for (int i = 0; i < len-1; i++)
	{
		for (int j = 0; j < (len - i) - 1; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				temp = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = temp;
			}
		}
	}

	for (int i = 0; i < len; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");
}

void DesSort(int* arr, int len)
{
	int temp = 0;

	for (int i = 0; i < len - 1; i++)
	{
		for (int j = 0; j < (len - i) - 1; j++)
		{
			if (arr[j] < arr[j + 1])
			{
				temp = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = temp;
			}
		}
	}

	for (int i = 0; i < len; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");
}

int main()
{
	//int arr[10];
	//for (int i = 0; i < 10; i++)
	//{
	//	printf("입력 : ");
	//	scanf("%d", &arr[i]);
	//}

	//for (int i = 0; i < 10; i++) // 기존 배열 출력
	//{
	//	printf("%d ", arr[i]);
	//}
	//printf("\n");

	//ShowOddNum(arr);
	//ShowEvenNum(arr);
	//
	//DecimalToBinary();

	//Example3();

	//char arr[100];
	//int Len = 0;

	//printf("문자열 입력: ");
	//scanf("%99s", arr);
	//
	//while (arr[Len] != 0)
	//{
	//	Len++;
	//}	
	//printf("입력된 문자열 : %s\n", arr);

	//ISPalindrome(&arr,Len);

	int arr[4] = { 3,2,4,1 };
	BubbleSort(&arr, sizeof(arr) / sizeof(int));
	
	int arr2[7];	
	for (int i = 0; i < 7; i++)
	{
		printf("입력 ");
		scanf("%d", &arr2[i]);
	}
	DesSort(&arr2, sizeof(arr2) / sizeof(int));


	return 0;
}
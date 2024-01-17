#include <stdio.h>

void ShowOddNum(int* arr)
{
	printf("Ȧ�� ���: ");
	for (int i = 0; i < 10; i++)
	{
		if(arr[i] % 2 != 0) // Ȧ�� -> 2�� ������ �������� 0�� �ƴ� ��
		printf("%d ", arr[i]);
	}
	printf("\n");
}

void ShowEvenNum(int* arr)
{
	printf("¦�� ���: ");
	for (int i = 0; i < 10; i++)
	{
		if(arr[i] % 2 == 0) // ¦�� -> 2�� ������ �������� 0�� ��
		printf("%d ", arr[i]);
	}
	printf("\n");
}

void DecimalToBinary(void)
{
	int Decimal;
	int Binary[20] = { 0, };
	int Position = 0;
	printf("10���� ���� �Է�: ");
	scanf("%d", &Decimal);
	// Dec�� 2�� ���� => ���� 0�� ���� ������
	// �������� �Ųٷ� ������ => 2������ ��ȯ��

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
		printf("�Է�: ");
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

	printf("������ ���ڿ� : %s\n", FlipedArr);

	for (int i = 0; i < len; i++)
	{
		int add = (FlipedArr[i] == arr[i]) ? 0 : 1;
		Total += add;
	}	
	
	if (Total == 0)
		printf("ȸ�� �Դϴ�.\n");
	else
		printf("ȸ���� �ƴմϴ�.\n");
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
	//	printf("�Է� : ");
	//	scanf("%d", &arr[i]);
	//}

	//for (int i = 0; i < 10; i++) // ���� �迭 ���
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

	//printf("���ڿ� �Է�: ");
	//scanf("%99s", arr);
	//
	//while (arr[Len] != 0)
	//{
	//	Len++;
	//}	
	//printf("�Էµ� ���ڿ� : %s\n", arr);

	//ISPalindrome(&arr,Len);

	int arr[4] = { 3,2,4,1 };
	BubbleSort(&arr, sizeof(arr) / sizeof(int));
	
	int arr2[7];	
	for (int i = 0; i < 7; i++)
	{
		printf("�Է� ");
		scanf("%d", &arr2[i]);
	}
	DesSort(&arr2, sizeof(arr2) / sizeof(int));


	return 0;
}
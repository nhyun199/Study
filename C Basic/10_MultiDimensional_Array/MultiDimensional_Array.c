#include <stdio.h>

int Record[5][5];

void WriteRecord(void)
{
	int sum;
	for (int i = 0; i < 4; i++)
	{
		sum = 0;
		printf("%d��° �л��� ���� �Է� \n", i + 1);
		for (int j = 0; j < 4; j++)
		{
			printf("%d��° ���� : ", j + 1);
			scanf("%d", &Record[i][j]);
			sum += Record[i][j];
		}
		Record[i][4] = sum;
	}
}

void WriteSumRecord(void)
{
	int sum;
	for (int i = 0; i < 4; i++)
	{
		sum = 0;
		for (int j = 0; j < 4; j++)
		{
			sum += Record[j][i];
		}
		Record[4][i] = sum;
		Record[4][4] += sum;
	}
}

void ShowAllRecord(void)
{
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			printf("%4d", Record[i][j]);
		}
		printf("\n");
	}
}

int main()
{
	int arr1[3][4]; // Type arr[���α���][���α���]
	int arr2[7][9];

	printf("���� 3, ����4 : %d\n", sizeof(arr1)); // ���� ũ�� * ���� ũ�� * sizeof(Type)
	printf("���� 7, ����9 : %d\n", sizeof(arr2));

	int GuGu[3][9];
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 9; j++)
		{
			GuGu[i][j] = (2 + i) * (1 + j);
		}
	}

	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 9; j++)
		{
			printf("%4d ", GuGu[i][j]);			
		}
		printf("\n");
	}
	printf("\n");

	int A[2][4] = { 1,2,3,4,5,6,7,8 };
	int B[4][2];

	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			B[i][j] = A[j][i];
		}
	}

	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			printf("%d ", A[i][j]);
		}
		printf("\n");
	}
	printf("\n");

	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			printf("%d ", B[i][j]);
		}
		printf("\n");
	}
	printf("\n");

	//int Score[5][5]= {0,};
	//int total = 0;
	//
	//for (int i = 0; i < 4; i++) // �� �л��� ���� ������ �Է�
	//{		
	//	int total = 0;
	//	
	//	for (int j = 0; j < 4; j++)
	//	{			
	//		if (i == 0)
	//		{
	//			printf("ö���� ����: ");
	//			scanf("%d", &Score[i][j]);			
	//		}
	//		else if (i == 1)
	//		{
	//			printf("ö���� ����: ");
	//			scanf("%d", &Score[i][j]);				
	//		}
	//		else if (i == 2)
	//		{
	//			printf("������ ����: ");
	//			scanf("%d", &Score[i][j]);				
	//		}
	//		else if (i == 3)
	//		{
	//			printf("������ ����: ");
	//			scanf("%d", &Score[i][j]);				
	//		}
	//	}
	//}
	//		
	//for (int i = 0; i < 4; i++)
	//{
	//	int total = 0;
	//	for (int j = 0; j < 4; j++)
	//	{
	//		total += Score[j][i];
	//		Score[4][i] = total;
	//	}
	//}

	//for (int i = 0; i < 4; i++)
	//{
	//	int total = 0;
	//	for (int j = 0; j < 4; j++)
	//	{
	//		total += Score[i][j];
	//		Score[i][4] = total;
	//	}
	//}

	//for (int i = 0; i < 4; i++)
	//{
	//	total += Score[4][i];
	//	Score[4][4] = total;
	//}


	//for (int i = 0; i < 5; i++)
	//{
	//	for (int j = 0; j < 5; j++)
	//	{
	//		printf("%d ", Score[i][j]);
	//	}
	//	printf("\n");
	//}

	WriteRecord();
	WriteSumRecord();
	ShowAllRecord();

	return 0;
}
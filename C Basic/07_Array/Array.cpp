#include <stdio.h>

int main()
{
	// �迭�� 3���� ���� ���
	//int arr1[5] = { 1,2,3,4,5 };
	//int arr2[] = { 1,2,3,4,5,6,7 }; // int arr2[7] = {1,2,3,4,5,6,7} �� ������, �����Ϸ����� �ڵ����� ���� ������ ������.
	//int arr3[5] = { 1, 2 }; // ������ �� ������ 0���� �ʱ�ȭ��.

	// sizeof : �迭�� �̸��� ������� �ϴ� ����
	//printf("�迭 arr1�� ũ�� : %d\n", sizeof(arr1)); // sizeof�� ��ȯ�ϴ� ���� �迭�� ���̰� �ƴ� "ũ��"�̴�.
	//printf("�迭 arr2�� ũ�� : %d\n", sizeof(arr2)); 
	//printf("�迭 arr3�� ũ�� : %d\n", sizeof(arr3));
	// int�� 4byte�̹Ƿ� ���ʴ�� 20, 28, 20�� ��ȯ�Ѵ�.

	//int i;
	//int arr1Len = sizeof(arr1) / sizeof(int); // �迭�� ���̸� ���ϱ� ���� int�� ũ��� ������ ��.
	//int arr2Len = sizeof(arr2) / sizeof(int);
	//int arr3Len = sizeof(arr3) / sizeof(int);

	/*for (i = 0; i < arr1Len; i++)
	{
		printf("%d ", arr1[i]);
	}
	printf("\n");

	for (i = 0; i < arr2Len; i++)
	{
		printf("%d ", arr2[i]);
	}
	printf("\n");

	for (i = 0; i < arr3Len; i++)
	{
		printf("%d ", arr3[i]);
	}*/

	/*int arr[5];	
	int max, min, sum;
	for (int i = 0; i < 5; i++)
	{
		printf("%d��° �迭 ��Ҹ� �Է��ϼ��� : ", i+1);
		scanf("%d", &arr[i]);
	}

	max = min = sum = arr[0];
	for (int i = 1; i < 5; i++)
	{
		sum += arr[i];

		if (max < arr[i])
			max = arr[i];

		if (min > arr[i])
			min = arr[i];
	}

	printf("�迭�� �ִ� : %d\n", max);
	printf("�迭�� �ּڰ� : %d\n", min);
	printf("�迭�� ���� : %d", sum);*/

	/*char arr[] = "Good time";
	int arrLen = sizeof(arr) / sizeof(char);
	for (int i = 0; i < arrLen; i++)
	{
		printf("%c", arr[i]);
	}
	printf("%d", arrLen);*/

	/*char sentence[50];
	int Len = 0;

	printf("���ܾ �Է��ϼ��� : ");
	scanf("%s", sentence);

	while (sentence[Len] != 0)
	{
		Len++;
	}

	printf("%s�� ���̴� %d�Դϴ�.", sentence, Len);*/

	/*char arr[100];
	int len = 0;
	char temp;
	
	printf("������ ���ܾ �Է��ϼ��� : ");
	scanf("%s", arr);

	while (arr[len] != 0)
	{
		len++;
	}

	for (int i = 0; i < len / 2; i++)
	{
		temp = arr[i];
		arr[i] = arr[(len - i) - 1];
		arr[(len - i) - 1] = temp;
	}
	printf("������ ���ܾ� : %s\n", arr);
	return 0;*/

	char arr[100];
	int len = 0;
	char MaxASC;

	printf("���ܾ �Է��ϼ��� : ");
	scanf("%s", arr);

	while (arr[len] != 0)
	{
		len++;
	}

	MaxASC = arr[0];

	for (int i = 0; i < len; i++)
	{
		if (MaxASC < arr[i])
			MaxASC = arr[i];
	}
	printf("%c", MaxASC);
}
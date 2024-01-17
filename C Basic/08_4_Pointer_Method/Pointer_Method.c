#include <stdio.h>
void ShowArray(int* param, int len) // (int param[], int len) �� �����ϴ�.
{
	for (int i = 0; i < len; i++)
		printf("%d ", param[i]);
	printf("\n");
}

void AddArray(int* param, int len, int add)
{
	for (int i = 0; i < len; i++)
		param[i] += add;	
}

int SquareByValue(int num)
{
	return num * num; // �ܼ��� �����Ͽ� ��ȯ��
}

void SquareByReference(int* ptr)
{
	*ptr = (*ptr) * (*ptr); // �����Ͽ� ������ ���� ������
}

void Swap3(int* ptr1, int* ptr2, int* ptr3)
{
	// num1���� num3�� ��, num2���� num1�� ��, num3���� num2�� ���� ����Ǿ����
	int temp1 = 0;
	int temp2 = 0;
	int temp3 = 0; 

	temp1 = *ptr1;
	temp2 = *ptr2;
	temp3 = *ptr3; // num1, 2, 3�� ���� �ӽ÷� ����

	*ptr1 = temp3;
	*ptr2 = temp1;
	*ptr3 = temp2; // num1, 2, 3�� ���� ��� ��ȯ
}


int main()
{
	int arr1[3] = { 1,2,3 };

	AddArray(arr1, sizeof(arr1) / sizeof(int), 10);
	ShowArray(arr1, sizeof(arr1) / sizeof(int));
	
	int num = 5;

	printf("������ ����� num�� �� : %d\n", num);
	printf("SquareByValue�� ���� ��ȯ�� �� : %d\n", SquareByValue(num));
	printf("SquareByValue�� ���� num�� ���ߴ°�? %d\n", num);
	SquareByReference(&num);
	printf("SquareByReference�� ���� num�� ���ߴ°�? %d\n", num);

	int num1 = 1, num2 = 2, num3 = 3;
	printf("Swap �� : %d %d %d\n", num1, num2, num3);
	Swap3(&num1, &num2, &num3);
	printf("Swap �� : %d %d %d\n", num1, num2, num3);
}
#include <stdio.h>
void ShowArray(int* param, int len) // (int param[], int len) 과 동일하다.
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
	return num * num; // 단순히 제곱하여 반환함
}

void SquareByReference(int* ptr)
{
	*ptr = (*ptr) * (*ptr); // 제곱하여 본래의 값에 저장함
}

void Swap3(int* ptr1, int* ptr2, int* ptr3)
{
	// num1에는 num3의 값, num2에는 num1의 값, num3에는 num2의 값이 저장되어야함
	int temp1 = 0;
	int temp2 = 0;
	int temp3 = 0; 

	temp1 = *ptr1;
	temp2 = *ptr2;
	temp3 = *ptr3; // num1, 2, 3을 먼저 임시로 저장

	*ptr1 = temp3;
	*ptr2 = temp1;
	*ptr3 = temp2; // num1, 2, 3의 값을 모두 교환
}


int main()
{
	int arr1[3] = { 1,2,3 };

	AddArray(arr1, sizeof(arr1) / sizeof(int), 10);
	ShowArray(arr1, sizeof(arr1) / sizeof(int));
	
	int num = 5;

	printf("기존에 저장된 num의 값 : %d\n", num);
	printf("SquareByValue에 의해 반환된 값 : %d\n", SquareByValue(num));
	printf("SquareByValue에 의해 num이 변했는가? %d\n", num);
	SquareByReference(&num);
	printf("SquareByReference에 의해 num이 변했는가? %d\n", num);

	int num1 = 1, num2 = 2, num3 = 3;
	printf("Swap 전 : %d %d %d\n", num1, num2, num3);
	Swap3(&num1, &num2, &num3);
	printf("Swap 후 : %d %d %d\n", num1, num2, num3);
}
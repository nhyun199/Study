#include <stdio.h>
int example1(void)
{
	printf("////// example1 //////\n");

	int arr[5] = { 1,2,3,4,5 };
	int* ptr = arr;

	for (int i = 0; i < 5; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");	
	
	for (int i = 0; i < 5; i++)
	{
		*(ptr++) += 2;
		printf("%d ", arr[i]);
	}

	printf("\n\n");

	return 0;
}

int example2(void)
{
	printf("////// example2 //////\n");

	int arr[5] = { 1,2,3,4,5 };
	int* ptr = arr;

	for (int i = 0; i < 5; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");
	
	for (int i = 0; i < 5; i++)
	{
		*(ptr + i) += 2;
		printf("%d ", arr[i]);
	}

	printf("\n\n");

	return 0;
}

int example3(void)
{
	printf("////// example3 //////\n");

	int arr[5] = { 1,2,3,4,5 };
	int* ptr = &arr[4];
	int total = 0;	

	for (int i = 0; i < 5; i++)
	{
		total += *(ptr--);		
	}
	printf("배열의 모든 정수의 합 : %d", total);

	printf("\n\n");

	return 0;
}

int example4(void)
{
	printf("////// example4 //////\n");

	int arr[6] = { 1,2,3,4,5,6 };
	int* ptrStart = arr;
	int* ptrEnd = &arr[5];
	int temp = 0;

	for (int i = 0; i < 6; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");

	for (int i = 0; i < 3; i++)
	{
		temp = *(ptrStart);
		*(ptrStart) = *(ptrEnd);
		*(ptrEnd) = temp;
		
		ptrStart++;
		ptrEnd--;
	}

	for (int i = 0; i < 6; i++)
	{
		printf("%d ", arr[i]);
	}	
	printf("\n");

	printf("\n\n");

	return 0;
}
int main()
{
	// 포인터에 대한 더하기를 실행하면 어떻게 될까?
	int a = 1;
	double b = 1.0;
	char c = 'A';

	int* ptr1 = &a;
	double* ptr2 = &b;
	char* ptr3 = &c;

	int size_int = sizeof(int); // 4
	int size_double = sizeof(double); // 8
	int size_char = sizeof(char); // 1

	printf("%p %p %p\n", ptr1, ptr2, ptr3);
	printf("%p %p %p\n", ptr1 + 1, ptr2 + 1, ptr3 + 1);
	printf("%p %p %p\n", ptr1 + 2, ptr2 + 2, ptr3 + 2);
	printf("sizeof(int) = %d\nsizeof(double) = %d\nsizeof(char) = %d\n", size_int, size_double, size_char);
	printf("\n");
	// 더한 수를 n이라고 했을 때,
	// 주소값은 n * sizeof(type) 만큼 증가한다.
	// 감소의 경우도 같은 방식이다.
	// 따라서 n에 따라서 ptr1 은 4, 8 .. ptr2 은 8, 16.. ptr3 은 1, 2.. 와 같이 증가하게된다.
	// sizeof(int) = 4, sizeof(double) = 8, sizeof(char) = 1 이기 때문이다.

	char str1[] = "My String";
	char* str2 = "Your string";

	example1();
	example2();
	example3();
	example4();

	return 0;
}
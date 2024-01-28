#include <stdio.h>

int main()
{
	int arr2D[3][3];
	printf("%d \n", arr2D);
	printf("%d \n", arr2D[0]);
	printf("%d \n\n", &arr2D[0][0]);

	printf("%d\n", arr2D[1]);
	printf("%d\n\n", &arr2D[1][0]);

	printf("%d\n", arr2D[2]);
	printf("%d\n\n", &arr2D[2][0]);	// 각 행의 첫번째 요소를 가리킴

	printf("sizeof(arr2d) : %d\n", sizeof(arr2D));
	printf("sizeof(arr2d[0]) : %d\n", sizeof(arr2D[0]));
	printf("sizeof(arr2d[1]) : %d\n", sizeof(arr2D[1]));
	printf("sizeof(arr2d[2]) : %d\n\n", sizeof(arr2D[2])); // 배열이름을 대상으로 한 sizeof 연산 -> 배열 전체 크기를 반환 
																// [0], [1], [2]를 대상으로 한 sizeof 연산 -> 각 행의 크기를 반환
																 
	// arr2D 와 arr2D[0]은 서로 다름. 2차원 배열의 배열 이름은 첫번째 요소를 가리키나, 배열 전체를 의미함. 
	// arr2D[0]도 첫번째 요소를 가리키나, 1행만을 의미함.

	int iarr[3];
	double darr[3];

	printf("iarr = %p, iarr+1 = %p\n", iarr, iarr + 1);
	printf("darr = %p, darr+1 = %p\n\n", darr, darr + 1);

	int arr1[3][2];
	int arr2[2][3];

	printf("arr1 : %p \n", arr1);
	printf("arr1+1 : %p \n", arr1+1);
	printf("arr1+2 : %p \n\n", arr1+2);
	// 1씩 증가할 때마다 주소값은 8이 증가함.

	printf("arr2 : %p \n", arr2);
	printf("arr2+1 : %p \n\n", arr2 + 1);
	// 1씩 증가할 때마다 주소값은 12가 증가함.

	// 배열을 이루는 자료형이 동일하더라도, 배열의 가로길이가 다르면 배열 이름을 대상으로 하는 포인터 연산의 결과는 달라지게 된다.

	int Arr1[2][2] = 
	{
		{1,2},{3,4}
	};

	int Arr2[3][2] =
	{
		{1,2},{3,4},{5,6}
	};

	int Arr3[4][2] =
	{
		{1,2},{3,4},{5,6},{7,8}
	};

	int(*ptr)[2];
	int i;

	ptr = Arr1;
	printf("** Show 2, 2 arr1 **\n");
	for (i = 0; i < 2; i++)
		printf("%d %d \n", ptr[i][0], ptr[i][1]);

	ptr = Arr2;
	printf("** Show 3, 2 arr1 **\n");
	for (i = 0; i < 3; i++)
		printf("%d %d \n", ptr[i][0], ptr[i][1]);

	ptr = Arr3;
	printf("** Show 4, 2 arr1 **\n");
	for (i = 0; i < 4; i++)
		printf("%d %d \n", ptr[i][0], ptr[i][1]);

	printf("\n");
	int num1 = 10, num2 = 20, num3 = 30, num4 = 40;
	int Arr2D[2][4] = { 1,2,3,4,5,6,7,8 };
	
	int* whoA[4] = { &num1, &num2, &num3, &num3 };
	int(*whoB)[4] = Arr2D;

	printf("%d %d %d %d\n", *whoA[0], *whoA[1], *whoA[2], *whoA[3]);
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 4; j++)
			printf("%d ", whoB[i][j]);
		printf("\n");
	}

	// 포인터 배열과 배열 포인터가 다르다는 걸 잊지않도록 하자.

	return 0;
}
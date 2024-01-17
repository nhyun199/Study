#include <stdio.h>

int main()
{
	// 배열의 3가지 선언 방식
	//int arr1[5] = { 1,2,3,4,5 };
	//int arr2[] = { 1,2,3,4,5,6,7 }; // int arr2[7] = {1,2,3,4,5,6,7} 과 동일함, 컴파일러에서 자동으로 길이 정보를 삽입함.
	//int arr3[5] = { 1, 2 }; // 나머지 빈 공간은 0으로 초기화됨.

	// sizeof : 배열의 이름을 대상으로 하는 연산
	//printf("배열 arr1의 크기 : %d\n", sizeof(arr1)); // sizeof가 반환하는 값은 배열의 길이가 아닌 "크기"이다.
	//printf("배열 arr2의 크기 : %d\n", sizeof(arr2)); 
	//printf("배열 arr3의 크기 : %d\n", sizeof(arr3));
	// int는 4byte이므로 차례대로 20, 28, 20을 반환한다.

	//int i;
	//int arr1Len = sizeof(arr1) / sizeof(int); // 배열의 길이를 구하기 위해 int의 크기로 나누어 줌.
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
		printf("%d번째 배열 요소를 입력하세요 : ", i+1);
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

	printf("배열의 최댓값 : %d\n", max);
	printf("배열의 최솟값 : %d\n", min);
	printf("배열의 총합 : %d", sum);*/

	/*char arr[] = "Good time";
	int arrLen = sizeof(arr) / sizeof(char);
	for (int i = 0; i < arrLen; i++)
	{
		printf("%c", arr[i]);
	}
	printf("%d", arrLen);*/

	/*char sentence[50];
	int Len = 0;

	printf("영단어를 입력하세요 : ");
	scanf("%s", sentence);

	while (sentence[Len] != 0)
	{
		Len++;
	}

	printf("%s의 길이는 %d입니다.", sentence, Len);*/

	/*char arr[100];
	int len = 0;
	char temp;
	
	printf("뒤집을 영단어를 입력하세요 : ");
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
	printf("뒤집힌 영단어 : %s\n", arr);
	return 0;*/

	char arr[100];
	int len = 0;
	char MaxASC;

	printf("영단어를 입력하세요 : ");
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
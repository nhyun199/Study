#include <stdio.h>

int main()
{
	// 배열의 이름도 포인터이며, 주소값은 배열의 첫번째 요소와 동일하다.
	char arr1[4] = { 'a', 'b', 'c', '\0'}; // 문자열에서 널연산자를 빼먹어서는 안된다.
	int len = 0;
	// 즉, char *ptr = &arr1[0] 이라고 했을 때, char *ptr = arr1 과 동일하다고 할 수 있다.
	

	while (arr1[len] != 0)
	{
		len++;
	}

	printf("배열의 이름 : %p\n", arr1);

	for (int i = 0; i < len; i++)
	{
		printf("%d번째 요소 : %p\n", i + 1, &arr1[i]);
	}
	// char는 1바이트이므로 요소간 주소값의 차이가 1씩 !

	/*int arr2[3] = { 1, 2, 3 };	

	printf("배열의 이름 : %p\n", arr2);

	for (int i = 0; i < 3; i++)
	{
		printf("%d번째 요소 : %p\n", i + 1, &arr2[i]);
	}*/
}

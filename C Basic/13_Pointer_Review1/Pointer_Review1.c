#include <stdio.h>

int main()
{
	// --------- Pointer Array ----------
	// ----------------------------------
	
	int a = 3, b = 5, c = 10;
	int* ptr_arr[3];

	printf("a의 주소 : %p\nb의 주소 : %p\nc의 주소 : %p\n", &a, &b, &c);
	printf("a의 값 : %d, b의 값 : %d, c의 값 : %d\n\n", a, b, c);

	ptr_arr[0] = &a;
	ptr_arr[1] = &b;
	ptr_arr[2] = &c; // 포인터 배열에 a, b, c의 주소를 저장함.

	printf("a를 가리키는 ptr_arr[0] : %p\nb를 가리키는 ptr_arr[1] : %p\nc를 가리키는 ptr_arr[2] : %p\n\n"
		  ,ptr_arr[0], ptr_arr[1], ptr_arr[2]);
	// 포인터 배열의 인덱서를 통해 가리키고 있는 주소를 호출할 수 있음.

	printf("a의 값을 나타내는 *ptr_arr[0] : %d\nb의 값을 나타내는 *ptr_arr[1] : %d\nc의 값을 나타내는 *ptr_arr[2] : %d\n\n"
		  ,*ptr_arr[0],*ptr_arr[1],*ptr_arr[2]);
	// 역참조를 통해 a, b, c의 값에도 접근할 수 있음.
	
	// ----------------------------------
	// ----------------------------------
	

	// --------- Array & Pointer ---------
	// -----------------------------------

	int int_arr[5] = { 1,2,3,4,5 }; // 1차원 배열의 선언
	printf("배열이름 int_arr : %p, int_arr[0]의 주소 : %p\nn", int_arr, &int_arr[0]);

	// 배열이름도 포인터이다. 배열이름은 배열의 첫번째 요소의 주소를 반환한다. 즉 int_arr == &int_arr[0] 이 성립한다.

	int* ptr1 = int_arr;
	printf("ptr1 : %p, int_arr : %p, int_arr[0] : %p\nn", ptr1, int_arr, &int_arr[0]);
	// 따라서 포인터를 선언하여, int_arr을 가리키는 것은 위와 모두 같은 것이다.
	
	printf("ptr1 + 1 : %p, ptr1[1] : %p, int_arr[1] : %p\n", ptr1 + 1, &ptr1[1], &int_arr[1]);
	// 포인터의 연산을 한 것에 대한 예시이다.
	// 따라서 ptr1 == ptr1 + 0 == ptr1[0] == int_arr[0] == int_arr 은 모두 참이다. 

	// 출력결과를 보면 ptr1 + 1 의 주소는 ptr1의 주소에서 sizeof(int) 만큼 증가된 주소임을 알 수 있다.

	printf("ptr1[0] : %d, *ptr1 : %d\n", ptr1[0], *ptr1);
	printf("*(ptr1+1) : %d, ptr1[1] : %d, int_arr[1] : %d\n\n", *(ptr1 + 1), ptr1[1], int_arr[1]);
	// 출력결과를 바탕으로 [], 즉 인덱서는 포인터의 역참조를 하는 것과 같은 역할을 한다고 볼 수 있다.
	
	// -----------------------------------
	// -----------------------------------

	return 0;
}
#include <stdio.h>

int main()
{
	double num = 3.14; 
	double* ptr = &num; // num의 주소값을 저장하는 포인터 "변수" ptr
	double** dptr = &ptr; // ptr도 변수이므로 주소를 가지고있으며, 그 주소를 이중 포인터를 통해 저장가능하다.
	double* ptr2;

	printf("%9p %9p\n", ptr, *dptr);
	printf("%9g %9g\n", num, **dptr);
	ptr2 = *dptr;
	*ptr2 = 10.99;
	printf("%9g %9g\n", num, **dptr);
	// ptr은 num을, dptr은 ptr을 가리키고 있다.
	

}
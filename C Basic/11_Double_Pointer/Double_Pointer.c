#include <stdio.h>

void MaxAndMin(int* arr, int size, int** Dptr1, int** Dptr2)
{
	int* max, * min;

	max = min = &arr[0];

}

int main()
{
	double num = 3.14;
	double* ptr = &num;
	double** dptr = &ptr;
	double* ptr2;

	printf("%9p %9p \n", ptr, *dptr);
	printf("%9g %9g \n", num, **dptr);

	ptr2 = *dptr;
	*ptr2 = 10.99;
	printf("%9g %9g \n", num, **dptr);


	int* maxPtr;
	int* minPtr;
	int arr[5] = { 3,2,1,4,7 };


	
	return 0;
}
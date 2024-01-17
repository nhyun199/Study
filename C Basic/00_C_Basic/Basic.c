#include <stdio.h> // 현재 프로젝트에 standard input/output 헤더 파일을 포함시키겠다.

int main() // 프로그램의 시작 진입점
{	
	int a;
	a = 10;
	int b = 127;
		
	printf("Hello, World!\n"); // 문자열을 출력할 것임
	printf("a의 값은 %d\n", a);

	printf("a의 값은 %d진수로 %o입니다.\n", 8, b);
	printf("a의 값은 %d진수로 %d입니다.\n", 10, b);
	printf("a의 값은 %d진수로 %x입니다.\n", 16, b);

	printf("%f\n", 1); // 정수를 실수 형식으로 출력하려고 하여 정확한 값이 출력되지 않음
	printf("%f\n", 1.0);
	return 0; // 함수의 종료, 적지 않아도 되지만 관례적으로 사용됨.
}







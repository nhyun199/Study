#include <stdio.h> // stdio.h 헤더파일을 포함시키라는 의미이다.

int main(void) // 출력형태 함수이름 (입력형태)
{
    printf("Hello world! \n");
    printf("노현\n노 현\n");
    printf("이름 : 노 현\n");
    printf("주소 : 경기도 평택시 서정동\n");
    printf("전화번호 : 010-7179-XXXX");
    return 0; // 현재 실행 중인 함수를 종료, 0은 윈도우나 리눅스 운영체제에서 프로그램의 종료 상태를 알리는 용도로 사용된다.
              // 비상적인 상황으로 인해서 종료될 때에는 일반적으로 0이 아닌 값을 전달한다.
}
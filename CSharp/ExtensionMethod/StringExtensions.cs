namespace ExtensionMethod
{
    public static class StringExtensions // 확장함수로 사용하기 위해 static 로 정의함
                                           // 확장함수가 static인 이유
                                           // 다른 객체의 기능을 확장하기 위해 사용, 객체를 생성하기 위해 사용하는 것이 아님
                                           // StringExtesions 라는 객체를 생성하는 것은 의미가 없음
                                           // 다른 객체에서 쉽게 접근하여 사용하기 위해
    {
        // 단어의 갯수를 세는 확장 기능 구현

        public static int WordCount(this string source)
        {
            return source.Split(new char[] { ' ', '.', ',', '!', '?' }, 
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}

/*
    작성일 : 2024년 03월 14일
    학과 : 컴퓨터 공학부
    학번 : 202395031
    이름 : 천승용
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Hello, World!\n");   // Write은 줄바꿈을 안함 
        Console.WriteLine("Hello, World!"); // WriteLine은 줄바꿈을 함

        // 정수 계산의 경우 답이 실수(0.2같은거) 가 되어도 답으로 정수(.포함 뒤에 것을 제외한값)이 나온다.
        Console.WriteLine(1/2); // 답 : 0

        // 나머지 연산자의 부호는 왼쪽 피연산자의 부호를 따른다. 그리고 실수 계산이 되지 않는다.
        Console.WriteLine(-1.0 / 2.0);  // 답 : -0.5

        // 작은 따옴표는 하나의 문자를 출력할때 쓴다.

        // \t 는 수평 탭, \\ 역슬래시, \n 행바꿈, \" 큰따옴표 출력
        Console.WriteLine("가\t \\ \n \"");

        // 문자열[숫자]는 문자를 선택하여 출력 할 수 있다. 
        Console.WriteLine("안녕하세요"[2]);  // 출력 : 하

        // 예외는 코드 실행 중 발생하는 오류 이다.
        // 예) 인덱스를 넘었을때 코드에선 오류가 없지만 출력할때 오류가 난다.

        // 작은따옴표는 +(문자열 합치기)가 적용이 되지 않는다.
        // Console.WriteLine('안' + '녕'); // 따른 값이 나옴
        Console.WriteLine('안' + '녕');
    }
}
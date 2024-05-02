internal class Program
{
    class Student
    {
        public string name;
        public int grade;
    }
    private static void ShowList(List<Student> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item.name + " : " + item.grade);
        }
    }
    private static void Main(string[] args)
    {
        List<Student> list = new List<Student>()
        {   // 중괄호가 없을 때는 list.Add(new Student(){name = "윤인성", grade = 1}); 이래 써야함
            new Student() {name = "윤인성", grade = 1},
            new Student() {name = "연하진", grade = 2},
            new Student() {name = "윤아리", grade = 3},
            new Student() {name = "윤명월", grade = 4},
            new Student() {name = "구지연", grade = 1},
            new Student() {name = "김연화", grade = 2}
        };

        ShowList(list);
        /*
        foreach (var item in list)
        {
            Console.WriteLine(item.name + " : " + item.grade);
        }
        */

    }
}
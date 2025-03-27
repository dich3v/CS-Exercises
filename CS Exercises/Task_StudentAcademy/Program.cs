namespace Task_StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> grades = new Dictionary<string, double>();
            Dictionary<string, int> count = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, grade);
                    count.Add(name, 1);
                }
                else
                {
                    grades[name] += grade;
                    count[name]++;
                }
            }
            foreach (KeyValuePair<string, double> kvp in grades)
            {
                string studentName = kvp.Key;
                double averageGrade = kvp.Value / count[studentName];
                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{studentName} -> {averageGrade:f2}");
                }
            }
        }
    }
}

namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
         Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");


        // create a dictionary to hold the student's names and the GPAs
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        // add the following name-grade pairs to the gradebook
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        // check if "Tom" has a record in gradebook
        if (!gradebook.ContainsKey("Tom"))
        {
            // if "Tom" is NOT in the gradebook, insert Tom into the gradebook with a GPA of 3.3
            gradebook.Add("Tom", 3.3);
        }

        // calculate the average GPA of all students
        double total = 0;
        // loop through the gradebook
        foreach (KeyValuePair<string, double> entry in gradebook)
        {
            // add the GPA to the total
            total += entry.Value;
        }

        // use the total to calculate the average GPA
        double average = total / gradebook.Count;

        // print out the average GPA
        Console.WriteLine("Average GPA: " + average);

        // print out information about students whose GPA is greater than the average GPA
        foreach (KeyValuePair<string, double> entry in gradebook)
        {
            // check if the GPA is greater than the average GPA
            if (entry.Value > average)
            {
                // print out the student's name
                Console.WriteLine(entry.Key + " has a GPA greater than the average GPA");
                // print the details of the student
                foreach (Student student in Student.student_list)
                {
                    // check if the student's name matches the name in the gradebook
                    if (student.GetStudentName() == entry.Key)
                    {
                        // print out the student's ID and name
                        student.PrintInfo();
                    }
                }
            }}}}
       public class Student
{
    // private variable studentID to hold the student ID
    private int studentID;
    // private variable studentName to hold the student name
    private string studentName;
    // public static variable student_list to hold a list of students
    public static List<Student> student_list = new List<Student>();

    // public constructor Student with two parameters
    public Student(int studentID, string studentName)
    {
        // assign the value of the parameter studentID to the private variable studentID
        this.studentID = studentID;
        this.studentName = studentName;
        // add this student object to the student_list
        student_list.Add(this);
    }

    // public method PrintInfo to print out the student ID and name
    public void PrintInfo()
    {
        Console.WriteLine("Student ID: " + studentID + " Student Name: " + studentName);
    }


    // getter method for studentID
    public int GetStudentID()
    {
        return studentID;
    }

    // getter method for studentName
    public string GetStudentName()
    {
        return studentName;
    }
}

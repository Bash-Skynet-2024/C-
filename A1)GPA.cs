string studentName = "Sophia Johnson";
Console.WriteLine("Student name  : " + studentName);

string course1Name = "English";
string course2Name = "Algebra";
string course3Name = "Biology";
string course4Name = "Computer Science";
string course5Name = "Psychology";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;
int gradeC = 2;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

Console.WriteLine("\nCourse Name\t\tCourse grade\t\tCourse credits");
Console.WriteLine($"{course1Name}\t\t\t\t\t{course1Grade}\t\t\t\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t\t\t{course2Grade}\t\t\t\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t\t\t{course3Grade}\t\t\t\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t\t\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t\t{course5Grade}\t\t\t\t\t{course5Credit}");

int totalCreditHours = 0;
totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

Console.WriteLine($"\nTotal Grade points : {totalGradePoints}\nTotal credit hourse : {totalCreditHours}");

decimal gradePointAverage = (decimal)totalGradePoints/(decimal)totalCreditHours;
Console.WriteLine($"\nFinal GPA: {gradePointAverage}");

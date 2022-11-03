// Grade calculator
Console.Write("Have you participated in the first written exam? Please enter Yes or No: ");
string firstexam = (Console.ReadLine()!);
double firstpoints = 0;
double secpoints = 0;
double passedexams = 0;
double percentage = 0;
double oralpoints = 0;
int grade = 0;
int grade2 = 0;
switch (firstexam)

{
    case "Yes":
        Console.Write("Please enter the number of points you got: ");
        firstpoints = double.Parse(Console.ReadLine()!);
        passedexams ++;
        break;
    case "No":
        Console.WriteLine("You haven't participated in the first exam.");
    break;
    default:
        Console.Clear();
        Console.WriteLine("You've entered wrong symbols. Try again. ");
        break;
}
Console.Write("Have you participated in the second written exam? Please enter Yes or No: ");
string secexam = (Console.ReadLine()!);
switch (secexam)
{
      case "Yes":
        Console.Write("Please enter the number of points you got: ");
        secpoints = double.Parse(Console.ReadLine()!);
        passedexams ++;
        break;
    case "No":
        Console.WriteLine("You haven't participated in the second exam.");
    break;
    default:
        Console.Clear();
        Console.WriteLine("You've entered wrong symbols. Try again: ");
        break;
}
Homeworkk:
Console.Write("How much points did you got through homework? (0-20): ");
double homework = double.Parse(Console.ReadLine()!);
if (homework > 0 && homework <= 20)
{

}
else
{
    Console.Write("You've given incorrect datas. Please try again: ");
    while (homework > 20)
    {
        goto Homeworkk;
    }
}


Console.Write("Have you participated in the oral exam? Please enter Yes or No: ");
string oralexam = (Console.ReadLine()!);
switch (oralexam)
{
      case "Yes":
        Console.Write("Please enter the number of points you got: ");
        oralpoints = double.Parse(Console.ReadLine()!);
        passedexams ++;
        break;
    case "No":
        Console.Write("You haven't participated in the oral exam.");
    break;
    default:
        Console.Clear();
        Console.WriteLine("You've entered wrong symbols. Try again: ");
        break;
}




double totalpoint = firstpoints + secpoints + homework + oralpoints;
        Console.WriteLine("You've got " + totalpoint + " Points.");
        double possiblePoints = 20*passedexams + 20;
        percentage = totalpoint / possiblePoints * 100;
double totalpoint2 = firstpoints + secpoints + oralpoints + 20;
double percentage2 = totalpoint2 / possiblePoints * 100;
if (percentage >= 89)
{
    grade = 1;

}
else if (percentage >= 76)
{
    grade = 2;
}
else if (percentage >= 63)
{
    grade = 3;
}
else if (percentage >= 50)
{
    grade = 4;
}
else if (percentage < 50)
{
    grade = 5;
}
else if (percentage == 0)
{}

Console.WriteLine("Your grade is " + grade + ", Congrats.");




if (percentage2 >= 89)
{
    grade2 = 1;
  
}
else if (percentage2 >= 76)
{
    grade2 = 2;

}
else if (percentage2 >= 63)
{
    grade2 = 3;
  
}
else if (percentage2 >= 50)
{
    grade2 = 4;
}
else if (percentage2 < 50)
{
    grade2 = 5;
}
else if (percentage2 == 0)
{}


if (grade2 == grade)
{}
else
{Console.WriteLine("You could have got the the mark " + grade2 + ".");}

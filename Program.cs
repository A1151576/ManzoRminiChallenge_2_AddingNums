/*
Rafael Manzo
Day School Week 1
Mini 2 add 2 numbers.
In this program we will be revising our code where we ask our user for two numers then add them together, adding data validation, as well as a play again feature.
10/18/22
*/
Console.Clear();
bool playover = true;
while (playover)
{
    Console.WriteLine("Lets add two numbers.");
    Console.WriteLine("Enter your first number.");
    string numOne = Console.ReadLine();


    Console.WriteLine("Enter your second number.");
    string numbertwo = Console.ReadLine();


    int num1 = Convert.ToInt32(numOne);
    int num2 = Convert.ToInt32(numbertwo);
    Console.WriteLine("Your answer is:" + (num1 + num2));

Console.WriteLine("would you like to play again? type no to quit or any key to play again.");
string answer01 = Console.ReadLine();
if (answer01 == "no")
{
    playover = false;
}

else
{
    Console.WriteLine("doesn't work, try again.");
}
}



//Console.WriteLine("Your answer is:" + (num1 + num2));

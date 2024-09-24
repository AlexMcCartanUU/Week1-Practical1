// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Task1();


    void Task1()
    {
        //add variables for the name and age 
        string name, ageRange;
        int age, futureAge, num, year, number;

        //ask the user what there name and age is and display to the screen
        Console.WriteLine("Please enter your name : ");
        name = Convert.ToString(Console.ReadLine());


        Console.WriteLine("Please enter your age : ");
        age = Convert.ToInt32(Console.ReadLine());
        futureAge = age + 5;

        Console.WriteLine("Hello " + name + " you will be " + futureAge + " in 5 years");

        //create a if statement to see if the useer is an adule teen or child
        //task2
        if (age >= 18 && age <=110)
        {
            ageRange = "Adult";
            Console.WriteLine("you are an " + ageRange);
        }
        else if (age >= 13 && age <= 17)
        {
            ageRange = "Teenager";
            Console.WriteLine("you are an " + ageRange);
        }
        else if (age >= 0 && age <= 12)
        {
            ageRange = "Child";
            Console.WriteLine("you are an " + ageRange);
        }
        else
        {
            Console.WriteLine("Invale age please try again");
        }


        //task3
        Console.WriteLine("Please enter a number ");
        num = Convert.ToInt32(Console.ReadLine());


        if (num <= -1)
        {
            Console.WriteLine("This is a negitave number ");
        }
        else if (num >= 1)
        {
        
            Console.WriteLine("This is a positive number");
        
        }
        else
        {
            Console.WriteLine("your number is zero");
        }


        //task 4
        Console.WriteLine("Enter a year and i will cheack if its a leap year");
        year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0)
        {
            Console.WriteLine("The year " + year + " is a leap year");
        }
        else
        {
            Console.WriteLine("The year " + year + " is not a leap year");
        }


        //Task5
        Console.WriteLine("please enter a number and i will tell you if its odd or even");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("This is an even number");
        }
        else
        {
            Console.WriteLine("This is an odd number");
        }

    }
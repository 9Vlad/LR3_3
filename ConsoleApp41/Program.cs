using System;

class Parent
{
    protected string Pole1;
    protected int Pole2;

    public Parent()
    {
        Random rand = new Random();
        Pole1 = "Чоловік";
        Pole2 = rand.Next(1980, 2005);
    }

    public Parent(string name, int birthday)
    {
        Pole1 = name;
        Pole2 = birthday;
    }

    public virtual void Print()
    {
        Console.WriteLine($"{Pole1} народився в {Pole2} році");
    }

    public int Metod1(int year)
    {
        return year - Pole2;
    }
}

class Child : Parent
{
    private int Pole3;

    public Child(string name, int birthday, int examScore) : base(name, birthday)
    {
        Pole3 = examScore;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"{Pole1} набрав {Pole3} балів");

        int age = Metod1(DateTime.Now.Year);
        Console.WriteLine($"Вік: {age} років");

        int passingScore = 8; // Приклад прохідного балу
        Console.WriteLine($"Прохідний бал {passingScore}. {(Pole3 >= passingScore ? "Поступив" : "Не поступив")}");
    }
}

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Parent person1 = new Parent();
        Child applicant1 = new Child("Абітурієнт", rand.Next(1995, 2005), rand.Next(1, 15));
        Child applicant2 = new Child("Абітурієнт", rand.Next(1995, 2005), rand.Next(1, 15));
        person1.Print();
        Console.WriteLine();
        applicant1.Print();
        Console.WriteLine();
        applicant2.Print();
    }
}
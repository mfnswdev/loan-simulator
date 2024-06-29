namespace LoanSimulator.Domain;

public class Customer
{
    private int Age;
    private string Cpf = null!;
    private string Name = null!;
    private double Income;
    private string Location = null!;

    public Customer(int age, string cpf, string name, double income, string location)
    {
        Age = age;
        Cpf = cpf;
        Name = name;
        Income = income;
        Location = location;
    }

    public bool isIncomeEqualOrLowerThan(double income)
    {
        return Income <= income;
    }

    public bool isIncomeEqualOrHigherThan(double income)
    {
        return Income >= income;
    }

    public bool isIncomeBetween(double min, double max)
    {
        return Income >= min && Income <= max;
    }

    public bool isAgeLowerThan(int value)
    {
        return Age < value;
    }

    public bool isFromLocation(string location)
    {
        return Location == location;
    }
}

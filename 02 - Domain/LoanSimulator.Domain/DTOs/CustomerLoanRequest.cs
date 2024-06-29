namespace LoanSimulator.Domain;

public record class CustomerLoanRequest
{
    public int Age { get; set; }
    public string Cpf { get; set; } = null!;
    public string Name { get; set; } = null!;
    public double Income { get; set; }
    public string Location { get; set; } = null!;

    public Customer toCustomer()
    {
        return new Customer(Age, Cpf, Name, Income, Location);
    }
}

namespace LoanSimulator.Domain;

public interface ILoanHandler
{
    public CustomerLoanResponse checkavailability(CustomerLoanRequest loanRequest);
}

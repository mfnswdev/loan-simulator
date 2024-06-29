namespace LoanSimulator.Domain;

public record class CustomerLoanResponse(string customer, List<LoanResponse> loans)
{

}

namespace LoanSimulator.Shared;

public record class CustomerLoanResponse(string customer, List<LoanResponse> loans)
{

}

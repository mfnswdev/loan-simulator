namespace LoanSimulator.Domain;

public class LoanHandler : ILoanHandler
{
    public CustomerLoanResponse checkavailability(CustomerLoanRequest loanRequest)
    {
        var customer = loanRequest.toCustomer();
        var loan = new Loan(customer);

        List<LoanResponse> loans = new List<LoanResponse>();

        if (loan.isPersonalLoanAvailiable())
        {
            loans.Add(new LoanResponse(LoanType.PERSONAL, loan.getPersonalLoanInterestRate()));
        }

        if (loan.isConsignmentLoanAvailiable())
        {
            loans.Add(new LoanResponse(LoanType.CONSIGNMENT, loan.getConsignmentLoanInterestRate()));
        }

        if (loan.isGuaranteedLoanAvailiable())
        {
            loans.Add(new LoanResponse(LoanType.GUARANTEED, loan.getGuaranteedLoanInterestRate()));
        }

        return new CustomerLoanResponse(loanRequest.Name, loans);


    }
}

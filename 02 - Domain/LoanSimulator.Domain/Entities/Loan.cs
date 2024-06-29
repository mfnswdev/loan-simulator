namespace LoanSimulator.Domain;

public class Loan
{
    private Customer customer;


    public Loan(Customer customer)
    {
        this.customer = customer;
    }

    public bool isPersonalLoanAvailiable()
    {
        return isBaseLoanAvailiable();
    }

    public bool isGuaranteedLoanAvailiable()
    {
        return isBaseLoanAvailiable();
    }

    public bool isConsignmentLoanAvailiable()
    {
        return customer.isIncomeEqualOrHigherThan(5000);
    }

    public double getPersonalLoanInterestRate()
    {
        if (isPersonalLoanAvailiable())
        {
            return 4.0;
        }
        throw new Exception("Personal loan not available");
    }

    public double getConsignmentLoanInterestRate()
    {
        if (isConsignmentLoanAvailiable())
        {
            return 2.0;
        }
        throw new Exception("Consignment loan not available");
    }

    public double getGuaranteedLoanInterestRate()
    {
        if (isGuaranteedLoanAvailiable())
        {
            return 3.0;
        }
        throw new Exception("Guaranteed loan not available");
    }

    private bool isBaseLoanAvailiable()
    {
        if (customer.isIncomeEqualOrLowerThan(3000))
        {
            return true;
        }
        return customer.isIncomeBetween(3000, 5000) && customer.isAgeLowerThan(30) && customer.isFromLocation("SP");
    }


}

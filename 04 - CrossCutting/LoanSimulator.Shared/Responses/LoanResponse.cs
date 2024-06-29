using LoanSimulator.Domain;

namespace LoanSimulator.Shared;

public record class LoanResponse(LoanType type, double interestRate)
{

}

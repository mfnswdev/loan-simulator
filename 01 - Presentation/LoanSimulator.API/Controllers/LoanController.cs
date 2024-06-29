using LoanSimulator.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LoanSimulator.API;

[ApiController]
[Route("[controller]")]
public class LoanController : ControllerBase
{

    private readonly ILoanHandler _loanHandler;
    public LoanController(ILoanHandler loanHandler)
    {
        _loanHandler = loanHandler;
    }

    [HttpPost]
    public ActionResult<CustomerLoanResponse> Post([FromBody] CustomerLoanRequest loanRequest)
    {
        var result = _loanHandler.checkavailability(loanRequest);

        return Ok(result);
    }
}
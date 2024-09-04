using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkingwithSQLLiteinAsp.NETCoreWebAPI.ApplicationDbContext;
//using WorkingwithSQLLiteinAsp.NETCoreWebAPI.Models;

[Route("api/[controller]")]
[ApiController]
public class InvestorsController : ControllerBase
{
    private readonly AppDbContext _context;

    public InvestorsController(AppDbContext context)
    {
       _context = context;
    }
[HttpGet("investors")]
public async Task<IActionResult> GetInvestors()
    {
        var investors = await _context.Investors
            .Include(i => i.Commitments)
            .Select(i => new
            {
                i.InvestorId,
                i.InvestorName,
                i.InvestorType,
                i.InvestorCountry,
                i.InvestorDateAdded,
                i.InvestorLastUpdated,

                TotalCommitments = (decimal)i.Commitments.Sum(c => (double)c.CommitmentAmount)
            })
            .ToListAsync();

        return Ok(investors);
    }

    
}
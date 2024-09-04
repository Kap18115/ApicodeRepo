using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkingwithSQLLiteinAsp.NETCoreWebAPI.ApplicationDbContext;
//using WorkingwithSQLLiteinAsp.NETCoreWebAPI.Models;

[Route("api/[controller]")]
[ApiController]
public class CommitmentsController : ControllerBase
{
    private readonly AppDbContext _context;

    public CommitmentsController(AppDbContext context)
    {
       _context = context;
    }
[HttpGet("investors/{id}")]
public async Task<ActionResult<IEnumerable<Commitment>>> GetInvestorCommitments(int id)
{
    //string AssetClass= '';

    var commitments = await _context.Commitments
        .Where(c => c.InvestorId == id).ToListAsync();
      
    return Ok(commitments);
}
[HttpGet("investors/{id}/commitments/{assetClass}")]
public async Task<ActionResult<IEnumerable<Commitment>>> GetCommitmentsByAssetClass(int id , string assetClass)
{
   

    var commitments = await _context.Commitments
        .Where(c => c.InvestorId == id && c.CommitmentAssetClass== assetClass )
        .ToListAsync();
    return Ok(commitments);
}

}

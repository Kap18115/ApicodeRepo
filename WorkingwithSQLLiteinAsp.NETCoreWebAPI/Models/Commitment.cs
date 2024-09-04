using System.ComponentModel.DataAnnotations;

public class Commitment
{
    [Key]
    public int CommitmentID { get; set; }
    public int InvestorId { get; set; }
    public string? CommitmentAssetClass { get; set; }
    public decimal CommitmentAmount { get; set; }
    public string? CommitmentCurrency { get; set; }
    public List<Commitment> CommitmentsDetails { get; set; }
	
	
	
}
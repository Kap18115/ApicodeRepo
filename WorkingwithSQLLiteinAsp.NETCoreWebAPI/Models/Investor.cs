public class Investor
{
    public int InvestorId { get; set; }
    public  string InvestorName { get; set; }
    public string InvestorType { get; set; }
    public string InvestorCountry { get; set; }
    public DateTime InvestorDateAdded { get; set; }
    public DateTime InvestorLastUpdated { get; set; }
    public List<Commitment> Commitments { get; set; }
}
namespace InsuranceCompany.Storage.Entities;

public class ContractRiskEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal? Premium { get; set; } 
    public decimal? InsuranceSum { get; set; } 
    
    public int ContractId { get; set; } 
    public ContractEntity Contract { get; set; } = null!;
}
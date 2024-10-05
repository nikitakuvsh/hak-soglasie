﻿using InsuranceCompany.Web.Models.Item;

namespace InsuranceCompany.Web.Models.Product;

public class UpdateFullProductDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int LOBId { get; set; }
    public bool Active { get; set; }
    
    public List<ItemBaseDto> Items { get; set; }
    public List<ProductRiskDto> Risks { get; set; }
    
    public string Formula { get; set; }
}
﻿using System.ComponentModel.DataAnnotations;

namespace Medical_Inventory.Models;

public class Company
{
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    public string Name { get; set; }

    [Required]
    [StringLength(15)]
    public string Phone { get; set; }
    
    [StringLength(50)]
    public string? Address { get; set; }
    
}
using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? City { get; set; }

    public string? Adress { get; set; }
}

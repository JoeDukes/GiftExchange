using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace GiftExchange.Models;

public class Gift
{
    public int Id {get; set;}
    public int UserId {get; set;}
    public string gift {get; set;} = "UnderPanties";
}

using System.ComponentModel.DataAnnotations;

namespace GiftExchange.Models;

public class Gift
{
    public int Id {get; set;}
    public int UserId {get; set;}
    public string gift {get; set;} = "UnderPanties";
}

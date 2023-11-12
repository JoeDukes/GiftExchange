using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GiftExchange.Models;

internal class GiftContext : DbContext
{
    public DbSet<Gift> Gifts {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @""
        );
    }
}

[Table("Gifts")]
public class Gift
{
    public int Id {get; set;}
    public int UserId {get; set;}
    public string gift {get; set;} = "UnderPanties";
}

enum family
{
    Russ,
    Sue,
    Jeff,
    Heather,
    Harry,
    Paxson,
    Joe,
    Dana,
    Oliver,
    Megan,
    Mike,
}

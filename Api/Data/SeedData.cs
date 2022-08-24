using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<ProjectEntity>().HasData(new List<ProjectEntity> {
            new ProjectEntity {
                Id = 1,
                Address = "12 Valley of Kings, Geneva",
                Country = "Switzerland",
                Description = "A superb detached Victorian property on one of the town's finest roads, within easy reach of Barnes Village. The property has in excess of 6000 sq/ft of accommodation, a driveway and landscaped garden.",
                Budget = 900000
            },
            new ProjectEntity
            {
                Id = 2,
                Address = "89 Road of Forks, Bern",
                Country = "Switzerland",
                Description = "This impressive family home, which dates back to approximately 1840, offers original period features throughout and is set back from the road with off street parking for up to six cars and an original Coach Project, which has been incorporated into the main Project to provide further accommodation. ",
                Budget = 500000
            },
            new ProjectEntity
            {
                Id = 3,
                Address = "Grote Hof 12, Amsterdam",
                Country = "The Netherlands",
                Description = "This Project has been designed and built to an impeccable standard offering luxurious and elegant living. The accommodation is arranged over four floors comprising a large entrance hall, living room with tall sash windows, dining room, study and WC on the ground floor.",
                Budget = 200500
            },
            new ProjectEntity
            {
                Id = 4,
                Address = "Meel Kade 321, The Hague",
                Country = "The Netherlands",
                Description = "Discreetly situated a unique two storey period home enviably located on the corner of Krom Road and Recht Road offering seclusion and privacy. The Project features a magnificent double height reception room with doors leading directly out onto a charming courtyard garden.",
                Budget = 259500
            },
            new ProjectEntity
            {
                Id = 5,
                Address = "Oude Gracht 32, Utrecht",
                Country = "The Netherlands",
                Description = "This luxurious three bedroom flat is contemporary in style and benefits from the use of a gymnasium and a reserved underground parking space.",
                Budget = 400500
            }
        });
        // builder.Entity<BidEntity>().HasData(new List<BidEntity>
        // {
        //     new BidEntity { Id = 1, ProjectId = 1, Bidder = "Sonia Reading", Amount = 200000 },
        //     new BidEntity { Id = 2, ProjectId = 1, Bidder = "Dick Johnson", Amount = 202400 },
        //     new BidEntity { Id = 3, ProjectId = 2, Bidder = "Mohammed Vahls", Amount = 302400 },
        //     new BidEntity { Id = 4, ProjectId = 2, Bidder = "Jane Williams", Amount = 310500 },
        //     new BidEntity { Id = 5, ProjectId = 2, Bidder = "John Kepler", Amount = 315400 },
        //     new BidEntity { Id = 6, ProjectId = 3, Bidder = "Bill Mentor", Amount = 201000 },
        //     new BidEntity { Id = 7, ProjectId = 4, Bidder = "Melissa Kirk", Amount = 410000 },
        //     new BidEntity { Id = 8, ProjectId = 4, Bidder = "Scott Max", Amount = 450000 },
        //     new BidEntity { Id = 9, ProjectId = 4, Bidder = "Christine James", Amount = 470000 },
        //     new BidEntity { Id = 10, ProjectId = 5, Bidder = "Omesh Carim", Amount = 450000 },
        //     new BidEntity { Id = 11, ProjectId = 5, Bidder = "Charlotte Max", Amount = 150000 },
        //     new BidEntity { Id = 12, ProjectId = 5, Bidder = "Marcus Scott", Amount = 170000 },
        // });
    }
}
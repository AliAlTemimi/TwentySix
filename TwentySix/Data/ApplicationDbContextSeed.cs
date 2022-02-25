using TwentySix.Models;

namespace TwentySix.Data
{
    public class ApplicationDbContextSeed
    {
        private readonly ApplicationDbContext _context;
        public ApplicationDbContextSeed(ApplicationDbContext dbContext)
        {
            this._context = dbContext;
        }

        public void seedUsers()
        {
            if (!_context.Users.Any())
            {
                var users = new List<User>()
                {
                    new User()
                    {
                        Id = 1,
                        FirstName = "Willis",
                        LastName =  "Tibbs",
                        DateActive = DateTime.Parse("05/02/2011"),
                        IsWebCustomer = true,
                        PreviouslyOrdered = false
                    },
                    new User()
                    {
                        Id = 2,
                        FirstName = "Sharon",
                        LastName =  "Halt",
                        DateActive = DateTime.Parse("26/07/2016"),
                        IsWebCustomer = false,
                        PreviouslyOrdered = false
                    },
                    new User()
                    {
                        Id = 3,
                        FirstName = "Patrick",
                        LastName =  "Kerr",
                        DateActive = DateTime.Parse("31/08/2016 "),
                        IsWebCustomer = true,
                        PreviouslyOrdered = true
                    },
                    new User()
                    {
                        Id = 4,
                        FirstName = "Lilly",
                        LastName =  "Hale",
                        DateActive = DateTime.Parse("01/01/2015"),
                        IsWebCustomer = false,
                        PreviouslyOrdered = false
                    },
                    new User()
                    {
                        Id = 5,
                        FirstName = "Joel",
                        LastName =  "Daly",
                        DateActive = DateTime.Parse("14/04/2014 "),
                        IsWebCustomer = true,
                        PreviouslyOrdered = true
                    },
                    new User()
                    {
                        Id = 6,
                        FirstName = "Imogen",
                        LastName =  "Kent",
                        DateActive = DateTime.Parse("17/02/2015"),
                        IsWebCustomer = false,
                        PreviouslyOrdered = false
                    },
                    new User()
                    {
                        Id = 7,
                        FirstName = "George",
                        LastName =  "Edwards",
                        DateActive = DateTime.Parse("05/11/2016 "),
                        IsWebCustomer = true,
                        PreviouslyOrdered = false
                    },
                    new User()
                    {
                        Id = 8,
                        FirstName = "Gabriel",
                        LastName =  "Franics",
                        DateActive = DateTime.Parse("29/05/2015"),
                        IsWebCustomer = false,
                        PreviouslyOrdered = false
                    },
                    new User()
                    {
                        Id = 9,
                        FirstName = "Courtney",
                        LastName =  "Arnold",
                        DateActive = DateTime.Parse("21/08/2014"),
                        IsWebCustomer = true,
                        PreviouslyOrdered = true
                    },
                    new User()
                    {
                        Id = 10,
                        FirstName = "Brian",
                        LastName =  "Allen",
                        DateActive = DateTime.Parse("11/04/2013"),
                        IsWebCustomer = true,
                        PreviouslyOrdered = true
                    },
                    new User()
                    {
                        Id = 11,
                        FirstName = "Bo",
                        LastName =  "Bob",
                        DateActive = DateTime.Parse("23/01/2017"),
                        IsWebCustomer = true,
                        PreviouslyOrdered = false
                    }
                };

                _context.Users.AddRange(users);
                _context.SaveChanges();
            }
        }
    }
}

namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrashCollection.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrashCollection.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.states.AddOrUpdate(
                s => s.name,
                new Models.States { name = "Alabama" },
                new Models.States { name = "Alaska" },
                new Models.States { name = "Arizona" },
                new Models.States { name = "Arkansas" },
                new Models.States { name = "California" },
                new Models.States { name = "Colorado" },
                new Models.States { name = "Connecticut" },
                new Models.States { name = "Delaware" },
                new Models.States { name = "Florida" },
                new Models.States { name = "Georgia" },
                new Models.States { name = "Hawaii" },
                new Models.States { name = "Idaho" },
                new Models.States { name = "Illinois" },
                new Models.States { name = "Indiana" },
                new Models.States { name = "Iowa" },
                new Models.States { name = "Kansas" },
                new Models.States { name = "Kentucky" },
                new Models.States { name = "Louisiana" },
                new Models.States { name = "Maine" },
                new Models.States { name = "Maryland" },
                new Models.States { name = "Massachusetts" },
                new Models.States { name = "Michigan" },
                new Models.States { name = "Minnesota" },
                new Models.States { name = "Missouri" },
                new Models.States { name = "Mississipi" },
                new Models.States { name = "Montana" },
                new Models.States { name = "Nebraska" },
                new Models.States { name = "Nevada" },
                new Models.States { name = "New Hampshire" },
                new Models.States { name = "New Jersey" },
                new Models.States { name = "New Mexico" },
                new Models.States { name = "New York" },
                new Models.States { name = "North Carolina" },
                new Models.States { name = "North Dakota" },
                new Models.States { name = "Ohio" },
                new Models.States { name = "Oklahoma" },
                new Models.States { name = "Oregon" },
                new Models.States { name = "Pennsylvania" },
                new Models.States { name = "Rhode Island" },
                new Models.States { name = "South Carolina" },
                new Models.States { name = "South Dakota" },
                new Models.States { name = "Tennesse" },
                new Models.States { name = "Texas" },
                new Models.States { name = "Utah" },
                new Models.States { name = "Vermont" },
                new Models.States { name = "Virginia" },
                new Models.States { name = "Washington" },
                new Models.States { name = "West Virginia" },
                new Models.States { name = "Wisconsin" },
                new Models.States { name = "Wyoming" }
                );
        }
    }
}

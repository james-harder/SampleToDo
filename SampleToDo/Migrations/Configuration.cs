namespace SampleToDo.Migrations
{
	using Microsoft.AspNet.Identity;
	using Microsoft.AspNet.Identity.EntityFramework;
	using SampleToDo.Models;
	using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SampleToDo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SampleToDo.Models.ApplicationDbContext";
        }

        protected override void Seed(SampleToDo.Models.ApplicationDbContext context)
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

			// Adding code to create a default user 
			if (!context.Users.Any(u => u.UserName == "test@test.com")){
				var uStore = new UserStore<ApplicationUser>(context);
				var manager = new UserManager<ApplicationUser>(uStore);
				var user = new ApplicationUser { UserName = "test@test.com" };

				manager.Create(user, "password");
			}

        }
    }
}

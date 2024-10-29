namespace Tejero__John_Daniel_M_Wam1_Inventory.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;

    internal sealed class Configuration : DbMigrationsConfiguration<Tejero__John_Daniel_M_Wam1_Inventory.Database.Context.SalesInventoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Tejero__John_Daniel_M_Wam1_Inventory.Database.Context.SalesInventoryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Roles.AddOrUpdate(
                r => r.RoleID,
                new Role { RoleName = "Admin", RoleDescription = "Administers the whole system" },
                new Role { RoleName = "Manager", RoleDescription = "Manages goods and categories" },
                new Role { RoleName = "Employee", RoleDescription = "Only responsible for sales and goods" }
            );

            context.Users.AddOrUpdate(
                r => r.UserID,
                new User { Username = "Admin", Firstname = "Administrator", Lastname = "Administrator", RoleID = 1, Password = "wasdwasd" },
                new User { Username = "Manager", Firstname = "Manager", Lastname = "Manager", RoleID = 2, Password = "wasdwasd" },
                new User { Username = "Employee", Firstname = "Employee", Lastname = "Employee", RoleID = 3, Password = "wasdwasd" }
            );

            context.Categories.AddOrUpdate(
                r => r.CategoryID,
                new Category { CategoryName = "General Items", Description = "Tag for General Items" },
                new Category { CategoryName = "Electronic Items", Description = "Tag for Electronic Items" }
            );
        }
    }
}

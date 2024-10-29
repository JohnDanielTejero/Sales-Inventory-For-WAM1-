namespace Tejero__John_Daniel_M_Wam1_Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 255, storeType: "nvarchar"),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CategoryID)
                .Index(t => t.CategoryName, unique: true);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.SalesItems",
                c => new
                    {
                        SalesId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.SalesId, t.ProductId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sales", t => t.SalesId, cascadeDelete: true)
                .Index(t => t.SalesId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SaleID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Date_Creation = c.DateTime(nullable: false, precision: 0),
                        CustomerName = c.String(unicode: false),
                        Total = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.SaleID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 255, storeType: "nvarchar"),
                        Firstname = c.String(unicode: false),
                        Lastname = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.Username, unique: true)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 255, storeType: "nvarchar"),
                        RoleDescription = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.RoleID)
                .Index(t => t.RoleName, unique: true);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Last_Updated = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "ProductID", "dbo.Products");
            DropForeignKey("dbo.SalesItems", "SalesId", "dbo.Sales");
            DropForeignKey("dbo.Sales", "UserID", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.SalesItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Stocks", new[] { "ProductID" });
            DropIndex("dbo.Roles", new[] { "RoleName" });
            DropIndex("dbo.Users", new[] { "RoleID" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Sales", new[] { "UserID" });
            DropIndex("dbo.SalesItems", new[] { "ProductId" });
            DropIndex("dbo.SalesItems", new[] { "SalesId" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.Categories", new[] { "CategoryName" });
            DropTable("dbo.Stocks");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Sales");
            DropTable("dbo.SalesItems");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}

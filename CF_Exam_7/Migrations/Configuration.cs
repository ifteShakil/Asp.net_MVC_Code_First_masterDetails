namespace CF_Exam_7.Migrations
{
    using CF_Exam_7.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CF_Exam_7.DAL.OrderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed= true;
        }

        protected override void Seed(CF_Exam_7.DAL.OrderContext context)
        {
            var categories = new List<Category>
            {
                new Category{CategoryName="Electronics"},
                new Category{CategoryName="Groceries"}
            };
            categories.ForEach(s => context.Categories.AddOrUpdate(c => c.CategoryName, s));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{CategoryID=1,ProductName="Laptop"},
                new Product{CategoryID=1,ProductName="Mobile"},

                new Product{CategoryID=2,ProductName="Rice"},
                new Product{CategoryID=2,ProductName="Potato"}
            };
            products.ForEach(s => context.Products.AddOrUpdate(c => c.ProductName, s));
            context.SaveChanges();
        }
    }
}

namespace DesafioHappe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertValuesInSideMenuMarket : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Alimentos')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Bebidas')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Frutas, verduras e legumes')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Higiene')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Arroz')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Farinha de Trigo')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Feijão')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Refrigerante')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Suco')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Água')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Batata')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Tomate')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Abacate')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Desodorante')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Sabonete')");
            Sql("INSERT INTO ItensSideMenuMarkets (Name) VALUES ('Xampu')");
        }


        public override void Down()
        {
        }
    }
}

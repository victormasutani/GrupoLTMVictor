using FluentMigrator;
using System;

namespace Migrations
{
    [Migration(20170907155600)]
    public class _20170907155600_SeedTableProduct : Migration
    {
        public override void Up()
        {
            Random random = new Random();
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Açaí", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Acerola", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Abacate", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Abacaxi", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Ameixa", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Amêndoa", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Amora", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Anona", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Araticum", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Babaço", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Banana", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Berinjela", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Bacuripari", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Cajá", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Caju", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Caqui", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Cambuci", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Carambola", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Cereja", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Coco", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Cupuaçu", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Cacau", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Castanha do Pará", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Damasco", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Figo", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Framboesa", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Goiaba", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Graviola", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Groselha", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Guaraná", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Ingá", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Jabuticaba", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Jaca", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Jambo", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Jambolão", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Laranja", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Limão", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Melancia", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Melão", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Manga", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Mamão", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Maracujá", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Marmelo", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Mexerica", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Mirtilo", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Morango", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Nectarina", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Noni", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Pinha", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Pequi", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Pera", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Pêssego", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Pitanga", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Pitaia", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Quiuí", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Romã", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Sapoti", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Tamarindo", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Tangerina", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Tomate", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Umbu", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Uva", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
            Insert.IntoTable("PRODUCT").Row(new { DSPRODUCT = "Uva verde", VLPRODUCT = Math.Round(random.NextDouble()*10, 2) });
        }

        public override void Down()
        {
            Delete.FromTable("PRODUCT").AllRows();
        }
    }
}
namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.product_detail", "color_id", "dbo.Color");
            //DropForeignKey("dbo.product_detail", "Product_Id", "dbo.tb_Product");
            //DropForeignKey("dbo.product_detail", "size_id", "dbo.Size");
            //DropIndex("dbo.product_detail", new[] { "color_id" });
            //DropIndex("dbo.product_detail", new[] { "size_id" });
            //DropIndex("dbo.product_detail", new[] { "Product_Id" });
            //CreateTable(
            //    "dbo.Size_color",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false),
            //            color_id = c.Int(nullable: false),
            //            size_id = c.Int(nullable: false),
            //            price = c.Decimal(precision: 18, scale: 2),
            //            quantity = c.Int(),
            //        })
            //    .PrimaryKey(t => new { t.Id, t.color_id, t.size_id })
            //    .ForeignKey("dbo.Color", t => t.color_id, cascadeDelete: true)
            //    .ForeignKey("dbo.tb_Product", t => t.Id, cascadeDelete: true)
            //    .ForeignKey("dbo.Size", t => t.size_id, cascadeDelete: true)
            //    .Index(t => t.Id)
            //    .Index(t => t.color_id)
            //    .Index(t => t.size_id);
            
            //DropTable("dbo.product_detail");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.product_detail",
                c => new
                    {
                        productdetails_id = c.Int(nullable: false),
                        color_id = c.Int(nullable: false),
                        size_id = c.Int(nullable: false),
                        price = c.Decimal(precision: 18, scale: 2),
                        quantity = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.productdetails_id, t.color_id, t.size_id });
            
            DropForeignKey("dbo.Size_color", "size_id", "dbo.Size");
            DropForeignKey("dbo.Size_color", "Id", "dbo.tb_Product");
            DropForeignKey("dbo.Size_color", "color_id", "dbo.Color");
            DropIndex("dbo.Size_color", new[] { "size_id" });
            DropIndex("dbo.Size_color", new[] { "color_id" });
            DropIndex("dbo.Size_color", new[] { "Id" });
            DropTable("dbo.Size_color");
            CreateIndex("dbo.product_detail", "Product_Id");
            CreateIndex("dbo.product_detail", "size_id");
            CreateIndex("dbo.product_detail", "color_id");
            AddForeignKey("dbo.product_detail", "size_id", "dbo.Size", "size_id", cascadeDelete: true);
            AddForeignKey("dbo.product_detail", "Product_Id", "dbo.tb_Product", "Id");
            AddForeignKey("dbo.product_detail", "color_id", "dbo.Color", "color_id", cascadeDelete: true);
        }
    }
}

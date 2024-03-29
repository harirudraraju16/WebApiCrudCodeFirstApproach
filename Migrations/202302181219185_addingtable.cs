﻿namespace WebApiCrudCodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Emp",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_Emp");
        }
    }
}

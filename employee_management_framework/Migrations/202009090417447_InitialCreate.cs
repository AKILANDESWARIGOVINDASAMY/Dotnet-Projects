namespace employee_management_framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Deptid = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.Deptid);
            
            CreateTable(
                "dbo.EmployeeDetails",
                c => new
                    {
                        EmpID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        pincode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeDetails");
            DropTable("dbo.Departments");
        }
    }
}

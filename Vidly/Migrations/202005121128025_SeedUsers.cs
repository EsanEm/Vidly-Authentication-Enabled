namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
               INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'40bff0fe-3840-46a2-9c79-3440e0ca6da9', N'admin@vidly.com', 0, N'AO81YovZXIY88yPwcsWVL4yKiIfxmT/40Ia2NpZj6e06CsWEOt2U48gxRRjuxa9pJw==', N'f138057f-0a71-4fa3-be85-530233ee38a2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
               INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'619f33fd-566d-4da4-bb64-9b2d10be7a47', N'guest@vidly.com', 0, N'AKGFj+r0oLDBvZnE2u2geCQeB068QPacEN7sVwCafAEVNk9xoQ5Rk/I+yw2TbKX5rA==', N'4b0e2e21-702e-4920-89dc-1f53c3f56830', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
           
               INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'889e3801-ef1a-4422-aff2-a4aa8d34fa3d', N'CanManageMovies')
                 
               INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'40bff0fe-3840-46a2-9c79-3440e0ca6da9', N'889e3801-ef1a-4422-aff2-a4aa8d34fa3d')
              ");
        }
        
        public override void Down()
        {
        }
    }
}

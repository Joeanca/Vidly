namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'67e3732f-0e51-4c3e-a001-5c7a83ff5c4e', N'guest@vidly.com', 0, N'AENo+P4N5YVpzeJ3Vfkg44+8H1vDHVRH1+yaalYhhQWKECQyQpK1jqSuXL41DRkUMg==', N'd0a1d554-46de-4f3a-99ed-e09524f9da8a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a2e15529-8153-4636-9a5b-d7396c03c66b', N'admin@vidly.com', 0, N'AGWbD7ovk82ilpTsz+X2twnzeZWEXM14KSBEJBTsOCWWK77t5MqcmHfILZ9KpzcNgw==', N'ce71b64e-fe2d-4182-b91d-22c34de7dc1a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fd222cf1-65a0-469a-bbed-d766b66121fb', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a2e15529-8153-4636-9a5b-d7396c03c66b', N'fd222cf1-65a0-469a-bbed-d766b66121fb')

");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'29da7622-3ef3-45ac-9350-936b48246d14', N'guest@vod.com', 0, N'AA913wZMI0MAPIaiVTLgb5fx9QqRIbuNtVzuy98ZpKyyD9uwYPktK0IZV0u47qxtUg==', N'819886e9-4bef-413d-a2d7-5cc4b8d7f258', NULL, 0, 0, NULL, 1, 0, N'guest@vod.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c266559-a873-4040-a96c-85cfca6307ac', N'admin@vod.com', 0, N'AKm6lT8VVi9IBcfqKXB43I0y1v9IbTQJLmhSeZ83XAn1N3Zi6b7WyUJ+OFo8Yu+XDw==', N'ae1fa778-d1aa-4e65-a573-06261549ab04', NULL, 0, 0, NULL, 1, 0, N'admin@vod.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd1cb0251-f783-4e58-9fa3-84f27686e246', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c266559-a873-4040-a96c-85cfca6307ac', N'd1cb0251-f783-4e58-9fa3-84f27686e246')


");

        }
        
        public override void Down()
        {
        }
    }
}

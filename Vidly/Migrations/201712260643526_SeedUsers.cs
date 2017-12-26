namespace Vidly.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class SeedUsers : DbMigration
	{
		public override void Up()
		{
			Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'631e8c14-af8c-427c-b49a-f3f2d5aecad4', N'guest@vidly.com', 0, N'ABiwvJB7x/sS7wvjzcJYUIX5QSx6SpL/U5IzY1hqF745x7CBEG6OPOhKDA0bVJbsdQ==', N'51118832-2aa7-404b-bdc0-435c54b3967d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ec20f6d3-2232-4706-a4dd-75ce4ae2597d', N'admin@vidly.com', 0, N'ALaesrKBmKABuWooj513VHqB547lH8tbg+1+qtVC0S0l6AYXlWmspUrUxCVhsVh8cw==', N'15e2960b-d889-4da0-bfef-8b313312329b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4ab50bdb-05ce-49d5-93b3-78920e669766', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ec20f6d3-2232-4706-a4dd-75ce4ae2597d', N'4ab50bdb-05ce-49d5-93b3-78920e669766')
");
		}

		public override void Down()
		{
		}
	}
}

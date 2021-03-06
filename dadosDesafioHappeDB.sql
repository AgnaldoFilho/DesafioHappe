USE [aspnet-DesafioHappe-20180206123838]
GO
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'88202efc-8e19-4326-a49c-96f6179624c8', N'agnaldo.filho@live.com', 0, NULL, N'258e6072-cd21-435e-bfa4-0d720eea215b', NULL, 0, 0, NULL, 1, 0, N'agnaldo.filho@live.com')
SET IDENTITY_INSERT [dbo].[ItensSideMenuMarkets] ON 

INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (9, N'Alimentos', NULL, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (10, N'Bebidas', NULL, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (11, N'Frutas, verduras e legumes', NULL, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (12, N'Higiene', NULL, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (13, N'Arroz', 9, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (14, N'Farinha de Trigo', 9, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (15, N'Feijão', 9, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (16, N'Refrigerante', 10, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (17, N'Suco', 10, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (18, N'Água', 10, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (19, N'Batata', 11, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (20, N'Tomate', 11, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (21, N'Abacate', 11, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (22, N'Desodorante', 12, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (23, N'Sabonete', 12, NULL, NULL)
INSERT [dbo].[ItensSideMenuMarkets] ([Id], [Name], [ParentId], [ApplicationUser_Id], [Route]) VALUES (24, N'Xampu', 12, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ItensSideMenuMarkets] OFF
SET IDENTITY_INSERT [dbo].[MenusForUsers] ON 

INSERT [dbo].[MenusForUsers] ([Id], [ItensSideMenuMarketId], [Ativo], [ApplicationUserId]) VALUES (1, 9, 1, N'88202efc-8e19-4326-a49c-96f6179624c8')
INSERT [dbo].[MenusForUsers] ([Id], [ItensSideMenuMarketId], [Ativo], [ApplicationUserId]) VALUES (2, 10, 1, N'88202efc-8e19-4326-a49c-96f6179624c8')
INSERT [dbo].[MenusForUsers] ([Id], [ItensSideMenuMarketId], [Ativo], [ApplicationUserId]) VALUES (3, 12, 1, N'88202efc-8e19-4326-a49c-96f6179624c8')
SET IDENTITY_INSERT [dbo].[MenusForUsers] OFF
INSERT [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [UserId]) VALUES (N'Facebook', N'1623997021013932', N'88202efc-8e19-4326-a49c-96f6179624c8')

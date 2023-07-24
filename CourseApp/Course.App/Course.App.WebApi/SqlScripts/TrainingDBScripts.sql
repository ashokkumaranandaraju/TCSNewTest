USE [TrainingDB]
GO

SET IDENTITY_INSERT [dbo].[Subscription] ON 
GO
INSERT [dbo].[Subscription] ([Id], [SubsCode], [TrainingCode], [Month], [Status], [Userid]) VALUES (1, N'S100', N'T101', N'Oct', N'Active', N'3837427')
GO
SET IDENTITY_INSERT [dbo].[Subscription] OFF
GO

SET IDENTITY_INSERT [dbo].[Training] ON 
GO
INSERT [dbo].[Training] ([Id], [TCode], [Name], [Course], [Month], [Status]) VALUES (1, N'T101', N'Web API Spring Session', N'.Net Web API', N'Sep', N'Active')
GO
INSERT [dbo].[Training] ([Id], [TCode], [Name], [Course], [Month], [Status]) VALUES (2, N'T101', N'Web API Spring Session', N'.Net Web API', N'Oct', N'Active')
GO
INSERT [dbo].[Training] ([Id], [TCode], [Name], [Course], [Month], [Status]) VALUES (3, N'T102', N'Angular Session', N'Angular 10', N'February', N'Open')
GO
SET IDENTITY_INSERT [dbo].[Training] OFF
GO

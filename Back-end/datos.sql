USE [SegurityCulturaTourDb]
GO
SET IDENTITY_INSERT [dbo].[LoginUser] ON 

INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (1, N'Roddy3889@gmail.com', N'12345')
INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (2, N'Rafael12345@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (3, N'roddy2125@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (4, N'nuevo@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (5, N'nuevoRoddy2125@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[LoginUser] ([id], [EmailLogin], [PasswordLogin]) VALUES (6, N'roddy21252@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
SET IDENTITY_INSERT [dbo].[LoginUser] OFF
GO
SET IDENTITY_INSERT [dbo].[SignUpUser] ON 

INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (1, N'Roddy R.', N'Rafael Tejeda', N'Rody3889@gmai.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (2, N'Rafael R.', N'Tejeda R.', N'Rafael12345@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (3, N'roddy', N'rafael', N'roddy2125@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (4, N'nuevo', N'prueba', N'nuevo@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (5, N'Roddy', N'nuevo', N'nuevoRoddy2125@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
INSERT [dbo].[SignUpUser] ([id], [Nombre], [Apellido], [EmailSignUp], [PasswordSignUp]) VALUES (6, N'Roddy2', N'nuevo', N'roddy21252@gmail.com', N'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
SET IDENTITY_INSERT [dbo].[SignUpUser] OFF
GO

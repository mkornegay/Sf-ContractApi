USE [Contracts]
GO

INSERT INTO [dbo].[Contract]
           ([ContractNo]
           ,[ContractDate]
           ,[ContractOrganization]
           ,[ContractType])
     VALUES
           ('MEM10252018'
           ,'10/25/2018'
           ,'Memorial Health University Hospital System'
           ,'Partner')

INSERT INTO [dbo].[Contract]
           ([ContractNo]
           ,[ContractDate]
           ,[ContractOrganization]
           ,[ContractType])
     VALUES
           ('UTH12122010'
           ,'12/12/2010'
           ,'Utah University Health System'
           ,'Equity')

INSERT INTO [dbo].[Contract]
           ([ContractNo]
           ,[ContractDate]
           ,[ContractOrganization]
           ,[ContractType])
     VALUES
           ('TEX08152001'
           ,'08/15/2001'
           ,'Texas Childrens Hospital Dallas'
           ,'Partner')

INSERT INTO [dbo].[Contract]
           ([ContractNo]
           ,[ContractDate]
           ,[ContractOrganization]
           ,[ContractType])
     VALUES
           ('MUT05041985'
           ,'05/04/1985'
           ,'Pennsylvania Mutual Health Cooperative'
           ,'Partner')

INSERT INTO [dbo].[Contract]
           ([ContractNo]
           ,[ContractDate]
           ,[ContractOrganization]
           ,[ContractType])
     VALUES
           ('CAL09152005'
           ,'09/15/2005'
           ,'California Baptist Health System'
           ,'Equity')
GO

USE [Contracts]
GO

INSERT INTO [dbo].[Item]
           ([Sku]
           ,[Description]
           ,[ListCost])
     VALUES
           ('43619310'
           ,'Aspiration Tube (10/case)'
           ,80.0000)
GO


INSERT INTO [dbo].[Item]
           ([Sku]
           ,[Description]
           ,[ListCost])
     VALUES
           ('43618710'
           ,'3000cc Implosion Proof Canister (10/case)'
           ,110.0000)
GO


INSERT INTO [dbo].[Item]
           ([Sku]
           ,[Description]
           ,[ListCost])
     VALUES
           ('43612501'
           ,'Disposable Autofuse Tubing'
           ,110.4000)
GO


INSERT INTO [dbo].[Item]
           ([Sku]
           ,[Description]
           ,[ListCost])
     VALUES
           ('11700525'
           ,'Otoscope/Opthalmoscope Diagnostic Set'
           ,595.0000)
GO


INSERT INTO [dbo].[Item]
           ([Sku]
           ,[Description]
           ,[ListCost])
     VALUES
           ('83541705'
           ,'Pediatric Blood Drawing Chair - Garden Green'
           ,1172.5400)
GO

USE [Contracts]
GO

INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (1,1)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (1,2)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (1,3)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (1,4)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (2,2)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (2,3)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (3,4)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (4,1)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (4,2)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (4,3)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (4,4)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (5,1)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (5,2)
INSERT INTO [dbo].[ContractItem] ([ContractId],[ItemId]) VALUES (5,3)
GO


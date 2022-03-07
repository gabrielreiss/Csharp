USE [suco_vendas]
GO

/****** Object:  Table [dbo].[TABELA DE PRODUTOS]    Script Date: 06/03/2022 21:15:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TABELA DE PRODUTOS](
	[CODIGO DO PRODUTO] [varchar](10) NULL,
	[NOME DO PRODUTO] [varchar](50) NULL,
	[EMBALAGEM] [varchar](20) NULL,
	[TAMANHO] [varchar](10) NULL,
	[SABOR] [varchar](20) NULL,
	[PREÇO DE LISTA] [smallmoney] NULL
) ON [PRIMARY]
GO



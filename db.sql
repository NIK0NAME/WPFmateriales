CREATE TABLE [MRWB].[acciones](
	[idAccion] [int] NOT NULL,
	[descri] [varchar](50) NOT NULL,
 CONSTRAINT [PK_acciones] PRIMARY KEY CLUSTERED 
(
	[idAccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [MRWB].[estados](
	[IdEstado] [int] NOT NULL,
	[descri] [varchar](50) NOT NULL,
 CONSTRAINT [PK_estados] PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [MRWB].[materiales](
	[idMaterial] [int] NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[descri] [varchar](50) NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_materiales] PRIMARY KEY CLUSTERED 
(
	[idMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [MRWB].[materiales]  WITH CHECK ADD  CONSTRAINT [FK_materiales_estados] FOREIGN KEY([estado])
REFERENCES [MRWB].[estados] ([IdEstado])
GO

ALTER TABLE [MRWB].[materiales] CHECK CONSTRAINT [FK_materiales_estados]
GO

CREATE TABLE [MRWB].[movimientos](
	[idMovimiento] [int] NOT NULL,
	[idMaterial] [int] NOT NULL,
	[accion] [int] NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_movimientos_1] PRIMARY KEY CLUSTERED 
(
	[idMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [MRWB].[movimientos]  WITH CHECK ADD  CONSTRAINT [FK_movimientos_acciones] FOREIGN KEY([idMaterial])
REFERENCES [MRWB].[acciones] ([idAccion])
GO

ALTER TABLE [MRWB].[movimientos] CHECK CONSTRAINT [FK_movimientos_acciones]
GO

ALTER TABLE [MRWB].[movimientos]  WITH CHECK ADD  CONSTRAINT [FK_movimientos_materiales] FOREIGN KEY([idMaterial])
REFERENCES [MRWB].[materiales] ([idMaterial])
GO

ALTER TABLE [MRWB].[movimientos] CHECK CONSTRAINT [FK_movimientos_materiales]
GO
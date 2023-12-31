USE [master]
GO
/****** Object:  Database [CarroonManagment]    Script Date: 2023-10-13 5:34:09 PM ******/
CREATE DATABASE [CarroonManagment]
GO
USE [CarroonManagment]
GO
Exec sp_changedbowner [sa]
GO 

CREATE TABLE [dbo].[Cartoon](
	[cartoonID] [decimal](20, 0) IDENTITY(1,1) NOT NULL,
	[cartoonName] [nvarchar](120) NOT NULL,
	[launchDate] [date] NOT NULL,
	[cartoonType] [int] NOT NULL,
	[shortDescription] [text] NOT NULL,
	[actors] [nvarchar](120) NOT NULL,
	[director] [nvarchar](120) NOT NULL,
	[country] [nvarchar](120) NOT NULL,
	[producer] [nvarchar](120) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cartoonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartoonType]    Script Date: 2023-10-13 5:34:10 PM ******/
CREATE TABLE [dbo].[CartoonType](
	[cartoonTypeID] [int] IDENTITY(1,1) NOT NULL,
	[cartoonName] [nvarchar](120) NULL,
PRIMARY KEY CLUSTERED 
(
	[cartoonTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cartoon]  WITH CHECK ADD  CONSTRAINT [FK_CartoonType] FOREIGN KEY([cartoonType])
REFERENCES [dbo].[CartoonType] ([cartoonTypeID])
GO
ALTER TABLE [dbo].[Cartoon] CHECK CONSTRAINT [FK_CartoonType]
GO
USE [master]
GO
ALTER DATABASE [CarroonManagment] SET  READ_WRITE 
GO

USE [CarroonManagment]
INSERT INTO CartoonType(cartoonName) VALUES ('DRAMA'),('ACTION'),('ROMANTIC'), ('CARTOON'), ('MUSICAL')

GO
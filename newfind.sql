USE [master]
GO
/****** Object:  Database [Bills]    Script Date: 10/7/2023 4:35:05 PM ******/
CREATE DATABASE [Bills]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bills', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NEWSQL\MSSQL\DATA\Bills.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bills_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NEWSQL\MSSQL\DATA\Bills_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bills] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bills].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bills] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bills] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bills] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bills] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bills] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bills] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bills] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bills] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bills] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bills] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bills] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bills] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bills] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bills] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bills] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bills] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bills] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bills] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bills] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bills] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bills] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bills] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bills] SET RECOVERY FULL 
GO
ALTER DATABASE [Bills] SET  MULTI_USER 
GO
ALTER DATABASE [Bills] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bills] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bills] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bills] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bills] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bills] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Bills', N'ON'
GO
ALTER DATABASE [Bills] SET QUERY_STORE = OFF
GO
USE [Bills]
GO
/****** Object:  UserDefinedFunction [dbo].[chickBilltype]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[chickBilltype] (@Billtype as int) 
returns bit
as
begin
	if @Billtype = 1 or @Billtype = 2
	begin 
		return 1
	end
	else 
	begin
		return 0
	end
	return -1
end;
GO
/****** Object:  Table [dbo].[TB_StockItem]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_StockItem](
	[itemGuid] [uniqueidentifier] NOT NULL,
	[status] [nvarchar](10) NOT NULL,
	[Quintity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Item]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Item](
	[itemGuid] [uniqueidentifier] NOT NULL,
	[itemcode] [int] NOT NULL,
	[itemName] [nvarchar](100) NULL,
	[itemPrice] [decimal](10, 2) NULL,
	[itemPriceSingle] [decimal](10, 2) NULL,
	[itemPriceMany] [decimal](10, 2) NULL,
	[parentGuid] [uniqueidentifier] NULL,
	[ISGroup] [bit] NOT NULL,
	[DateOfInsert] [date] NOT NULL,
 CONSTRAINT [PK_TBitem] PRIMARY KEY CLUSTERED 
(
	[itemGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [unique_itemcode] UNIQUE NONCLUSTERED 
(
	[itemcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Stock_Item]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Stock_Item]
AS
SELECT        dbo.TB_Item.itemName, dbo.TB_StockItem.status
FROM            dbo.TB_StockItem INNER JOIN
                         dbo.TB_Item ON dbo.TB_StockItem.itemGuid = dbo.TB_Item.itemGuid
GO
/****** Object:  View [dbo].[View_Show_stock]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Show_stock]
AS
SELECT        dbo.TB_Item.itemGuid, dbo.TB_Item.itemName, dbo.TB_StockItem.Quintity, dbo.TB_StockItem.status
FROM            dbo.TB_Item INNER JOIN
                         dbo.TB_StockItem ON dbo.TB_Item.itemGuid = dbo.TB_StockItem.itemGuid
GO
/****** Object:  Table [dbo].[TB_Bill]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Bill](
	[BillGuid] [uniqueidentifier] NOT NULL,
	[Billcode] [int] NOT NULL,
	[BillDate] [datetime] NULL,
	[Notes] [ntext] NULL,
	[BillType] [bit] NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Billitems]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Billitems](
	[BillitemGuid] [uniqueidentifier] NOT NULL,
	[BillitemID] [int] NOT NULL,
	[BillGuid] [uniqueidentifier] NULL,
	[itemGuid] [uniqueidentifier] NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Billitems] PRIMARY KEY CLUSTERED 
(
	[BillitemGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_SHOW]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_SHOW]
AS
SELECT        dbo.TB_Billitems.BillitemID, dbo.TB_Bill.Billcode, dbo.TB_Item.itemcode, dbo.TB_Item.itemName, dbo.TB_Billitems.Quantity, dbo.TB_Billitems.Price, dbo.TB_Bill.BillDate, 
                         CASE TB_Bill.BillType WHEN 1 THEN 'buy' WHEN 2 THEN 'sell' END AS BillType
FROM            dbo.TB_Bill INNER JOIN
                         dbo.TB_Billitems ON dbo.TB_Bill.BillGuid = dbo.TB_Billitems.BillGuid INNER JOIN
                         dbo.TB_Item ON dbo.TB_Billitems.itemGuid = dbo.TB_Item.itemGuid
GO
ALTER TABLE [dbo].[TB_Bill] ADD  CONSTRAINT [DF_TB_Bill_Billcode]  DEFAULT ((0)) FOR [Billcode]
GO
ALTER TABLE [dbo].[TB_Bill] ADD  CONSTRAINT [DF_TB_Bill_BillType]  DEFAULT ((0)) FOR [BillType]
GO
ALTER TABLE [dbo].[TB_Billitems] ADD  CONSTRAINT [DF_TB_Billitems_BillitemID]  DEFAULT ((0)) FOR [BillitemID]
GO
ALTER TABLE [dbo].[TB_Billitems] ADD  CONSTRAINT [DF_TB_Billitems_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[TB_Billitems] ADD  CONSTRAINT [DF_TB_Billitems_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[TB_Billitems] ADD  CONSTRAINT [DF_TB_Billitems_Total]  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[TB_Item] ADD  CONSTRAINT [DF_TB_Item_itemcode]  DEFAULT ((0)) FOR [itemcode]
GO
ALTER TABLE [dbo].[TB_Item] ADD  CONSTRAINT [DF_TB_Item_itemPrice]  DEFAULT ((0)) FOR [itemPrice]
GO
ALTER TABLE [dbo].[TB_Item] ADD  CONSTRAINT [DF_TB_Item_itemPriceSingle]  DEFAULT ((0)) FOR [itemPriceSingle]
GO
ALTER TABLE [dbo].[TB_Item] ADD  CONSTRAINT [DF_TB_Item_itemPriceMany]  DEFAULT ((0)) FOR [itemPriceMany]
GO
ALTER TABLE [dbo].[TB_Item] ADD  CONSTRAINT [DF_TB_Item_ISGroup]  DEFAULT ((0)) FOR [ISGroup]
GO
ALTER TABLE [dbo].[TB_Item] ADD  CONSTRAINT [DF_TB_Item_DateOfInsert]  DEFAULT (getdate()) FOR [DateOfInsert]
GO
ALTER TABLE [dbo].[TB_StockItem] ADD  CONSTRAINT [DF_StockItem_status]  DEFAULT (' ') FOR [status]
GO
ALTER TABLE [dbo].[TB_StockItem] ADD  CONSTRAINT [DF_StockItem_Quintity]  DEFAULT ((0)) FOR [Quintity]
GO
ALTER TABLE [dbo].[TB_Billitems]  WITH CHECK ADD  CONSTRAINT [FK_Billitems_Bill] FOREIGN KEY([BillGuid])
REFERENCES [dbo].[TB_Bill] ([BillGuid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TB_Billitems] CHECK CONSTRAINT [FK_Billitems_Bill]
GO
ALTER TABLE [dbo].[TB_Billitems]  WITH CHECK ADD  CONSTRAINT [FK_Billitems_TBitem] FOREIGN KEY([itemGuid])
REFERENCES [dbo].[TB_Item] ([itemGuid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TB_Billitems] CHECK CONSTRAINT [FK_Billitems_TBitem]
GO
ALTER TABLE [dbo].[TB_StockItem]  WITH CHECK ADD  CONSTRAINT [FK_StockItem_TB_Item] FOREIGN KEY([itemGuid])
REFERENCES [dbo].[TB_Item] ([itemGuid])
GO
ALTER TABLE [dbo].[TB_StockItem] CHECK CONSTRAINT [FK_StockItem_TB_Item]
GO
/****** Object:  StoredProcedure [dbo].[checkParent]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- انته ابن منو 
create PROC [dbo].[checkParent] (@child UNIQUEIDENTIFIER ,@parent UNIQUEIDENTIFIER,@item INT OUTPUT) 
AS
BEGIN

	WITH RecursiveItemCTE AS (
    SELECT ItemGuid,ItemName, ParentGuid
    FROM TB_Item
    WHERE ParentGuid = @parent

    UNION ALL

    SELECT i.ItemGuid, i.ItemName, i.ParentGuid
    FROM TB_Item i
    INNER JOIN RecursiveItemCTE cte ON i.ItemGuid = cte.ParentGuid
)
SELECT @item = 1
	   
	  FROM RecursiveItemCTE ct join	RecursiveItemCTE tc ON ct.ItemGuid = tc.ParentGuid 
	  WHERE	tc.ItemGuid=@child OR tc.ParentGuid= @parent;

PRINT @item;
return @item;
END;
/*
WITH RecursiveItemCTE AS (
    SELECT ItemGuid,ItemName, ParentGuid
    FROM TB_Item
    WHERE ItemGuid = @ChildItemGuid

    UNION ALL

    SELECT i.ItemGuid, i.ItemName, i.ParentGuid
    FROM TB_Item i
    INNER JOIN RecursiveItemCTE cte ON i.ItemGuid = cte.ParentGuid
)
SELECT *
FROM RecursiveItemCTE



*/
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[TB_Bill_Delete]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TB_Bill_Delete]
	@guid as uniqueidentifier = 0x0
as
	begin

	begin try 
		BEGIN TRANSACTION;

				delete from TB_Bill where BillGuid = @guid;
				COMMIT;
				return 1;

	end try
	
	begin catch
		SELECT
		ERROR_NUMBER() AS ErrorNumber,
		ERROR_MESSAGE() AS ErrorMessage; 
		commit;
		return 0;
		end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[TB_Bill_GET]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TB_Bill_GET]
	@guid as uniqueidentifier = 0x0
as
	begin

	begin try 
	BEGIN TRANSACTION;
	if @guid is null or @guid = 0x0
		begin
		select BillGuid, Billcode, BillDate, Notes ,
		 case BillType 
		 when  0 then 'buy'
		 when  1 then 'sell'
		 end as 'error'

		from TB_Bill
		order by Billcode;
		COMMIT;
		return 1;
	end
		else
		begin
		select BillGuid, Billcode, BillDate, Notes ,
		 case BillType 
		 when  0 then 'buy'
		 when  1 then 'sell'
		 end as 'BillType'

		from TB_Bill
		order by Billcode;
		commit ;
		return 1;

	end
	end try
	
	begin catch

		SELECT
		ERROR_NUMBER() AS ErrorNumber,
		ERROR_MESSAGE() AS ErrorMessage;
		commit;
		return 0;
	
	end catch
end;

GO
/****** Object:  StoredProcedure [dbo].[TB_Bill_Get_BillType]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TB_Bill_Get_BillType] AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select DISTINCT BillType from TB_Bill; 
 
END
GO
/****** Object:  StoredProcedure [dbo].[TB_Bill_Get_FirstLastBetween]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TB_Bill_Get_FirstLastBetween] (
	
	@status varchar(50)

)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		begin tran
			begin try

				if @Status = 'ASC' begin
					select top 1 * from TB_Bill order by Billcode asc
				end

				else if @Status = 'DESC' begin
					select top 1 * from TB_Bill order by Billcode desc
				end

			end try

			begin catch

			end catch



    -- Insert statements for procedure here
	
END
GO
/****** Object:  StoredProcedure [dbo].[TB_Bill_Get1]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TB_Bill_Get1] @chicker nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

	if @chicker = 'first' 
	begin
		select top 1 * from TB_Bill order by Billcode;
	end
	else if @chicker = 'last' 
	begin
		select top 1 * from TB_Bill order by Billcode desc;
	end

END
GO
/****** Object:  StoredProcedure [dbo].[TB_Bill_Save]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TB_Bill_Save]
    (
		@guid as uniqueidentifier = 0x0 output,
		@billcode as int,
		@notes as ntext,
		@date  as datetime = null,
		@Billtype as bit
	)
as
	begin
    begin try 
		BEGIN TRANSACTION;
		if not exists (select 1 from TB_Bill where BillGuid = @guid)

--		if @guid = 0x0 or @guid is null
		begin

			set @guid = newid();
			declare @Billid as int;
			select @Billid = isnull (max(TB_Bill.Billcode)+1, 1)
			from TB_Bill;

			set @date  = format(getdate(),'yyyy-MM-dd HH:mm:ss')
			if exists (select dbo.chickBilltype(@billtype))
		BEGIN 
			
			insert into TB_Bill
				(BillGuid, Billcode, BillDate, Notes, BillType)
			values
				(@guid, @Billid, @date, @notes, @Billtype);
			print('insert done');
			
			commit;
			return 1;
		END;
	ELSE 
		BEGIN
			RETURN 0;
		END;
	end;
			else
			begin
        if exists (select dbo.chickBilltype(@billtype))
			begin
			set @date  = format(@date,'yyyy-MM-dd HH:mm:ss')
            update TB_Bill set 
				Notes = @notes,
				BillType = @billtype,
				BillDate = @date
				where BillGuid = @guid;

            print('update done');
            commit;
            return 1;
        end;
    end;
		COMMIT;
		end try
		begin catch
			SELECT
		   ERROR_NUMBER() AS ErrorNumber ,
		   ERROR_MESSAGE() AS ErrorMessage; 
		   commit;
		return 0;
		end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[TB_BillItem_Delete]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TB_BillItem_Delete] 
	@BillitemGUID as uniqueidentifier = 0x0 output
as 
begin
	
	begin try
		BEGIN TRANSACTION;
		IF @BillitemGUID IS NULL OR @BillitemGUID = 0x0
			BEGIN
				delete from TB_Billitems where BillitemGuid = @BillitemGUID;
			COMMIT;
				PRINT('DELETE DONE');
			RETURN 1;
			END;
		ELSE
		BEGIN 
			delete from TB_Billitems;
			PRINT('DELETE ALL DONE')
		COMMIT;
		RETURN 1;
		END;
	end try
	begin catch
		SELECT   
		ERROR_NUMBER() AS ErrorNumber, 
		ERROR_MESSAGE() AS ErrorMessage; 
		COMMIT;
		RETURN 0;
	end catch

end;
GO
/****** Object:  StoredProcedure [dbo].[TB_BillItem_GET]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TB_BillItem_GET]
	@guid as uniqueidentifier = 0x0
as
begin

	begin try
	
	BEGIN TRANSACTION;
	
	if @guid is null or @guid=0x0
	begin

		select BillitemID, TB_Bill.Billcode, TB_Item.itemcode, itemName , quantity , TB_Billitems.Price , total,
			case TB_Bill.BillType 
			 when  1 then 'buy'
			 when  2 then 'sell'
			 end as 'error type'
		from TB_Billitems
			join
			TB_Bill on TB_Bill.BillGuid = TB_Billitems.BillGuid
			join
			TB_Item
			on
		TB_Item.itemGuid = TB_Billitems.itemGuid
		order by  BillitemID, Billcode;
		COMMIT;
		RETURN 1;

	end;


	ELSE
	BEGIN
		select BillitemID, TB_Bill.Billcode, TB_Item.itemcode, itemName , quantity , TB_Billitems.Price , total,
			case TB_Bill.BillType 
			 when  1 then 'buy'
			 when  2 then 'sell'
			 end as 'error type'
		from TB_Billitems
			join
			TB_Bill on TB_Bill.BillGuid = TB_Billitems.BillGuid
			join
			TB_Item
			on
		TB_Item.itemGuid = TB_Billitems.itemGuid
		WHERE BillitemGuid = @guid
		order by  BillitemID, Billcode;
		COMMIT;
		RETURN 1;
	END;
	end try


	begin catch
		SELECT
		ERROR_NUMBER() AS ErrorNumber,
		ERROR_MESSAGE() AS ErrorMessage; 
		commit;
		return 0;
	end catch

end;
GO
/****** Object:  StoredProcedure [dbo].[TB_BillItem_Save]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TB_BillItem_Save]
	@guid as uniqueidentifier = 0x0 output,
	@BillGuid as uniqueidentifier,
	@ItemGuid as uniqueidentifier,
	@billitemid as int,
	@Quantity as int,
	@Price as decimal (10,2)
as
begin

	begin try 
	BEGIN TRANSACTION;
		
		IF NOT EXISTS (
		SELECT 1 FROM TB_Billitems WHERE BillGuid = @BillGuid 
		AND itemGuid = @ItemGuid 
		AND BillitemID = @billitemid)

		--if @guid is null or @guid =0x0
		begin
		set @guid = NEWID();
		insert into TB_Billitems
			(
				BillitemGuid, BillGuid, itemGuid,
				BillitemID, Quantity, Price, Total
			)

		values
			(
				@guid, @BillGuid, @ItemGuid,
				@billitemid, @Quantity,
				@Price, @Price * @Quantity
			)
			PRINT('INSERT DONE');
		commit;
		return 1;
	end;
		else
		begin
		update TB_Billitems set
		 BillGuid = @BillGuid, itemGuid = @ItemGuid,
		 BillitemID = @billitemid, Quantity= @Quantity, Price = @Price,
		 Total = @Price * @Quantity
		 where BillitemGuid = @guid;

		 PRINT('UPDATE DONE');
		 commit;
		return 1;
	end;

		COMMIT;

	end try
	
	begin catch
		SELECT
		ERROR_NUMBER() AS ErrorNumber,
		ERROR_MESSAGE() AS ErrorMessage; 
		PRINT('ERROR')
		commit;
		return 0;
		end catch

end;
GO
/****** Object:  StoredProcedure [dbo].[TB_Item_Delete]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[TB_Item_Delete] @guid as uniqueidentifier = 0x0
	as
	begin

	begin try 
		BEGIN TRANSACTION;
			declare @flag as bit = 0
			
			select @flag =1 from TB_Billitems where itemGuid = @guid;

			if @flag = 0
			
			begin 
				delete from TB_Item where itemGuid = @guid;
			commit;
			return 1;
			end;

			else
			begin
			commit;
				return 2;
			end;

	commit;
	end try
	
	begin catch
		SELECT   
		ERROR_NUMBER() AS ErrorNumber, 
		ERROR_MESSAGE() AS ErrorMessage; 
		commit;
		return 0;
		end catch
	end;
GO
/****** Object:  StoredProcedure [dbo].[TB_item_GET]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TB_item_GET]
	@guid as uniqueidentifier = 0x0
	as
	begin

	begin try 
	BEGIN TRANSACTION;
	if @guid is null or @guid = 0x0
		 begin
		select * from TB_Item order by itemcode;
		
		COMMIT;
		return 1;
		end;
		else 
		 begin
			select * from TB_Item where itemGuid = @guid;
		 commit;
		 return 1;
		 end
	end try
	
	begin catch
		SELECT   
		ERROR_NUMBER() AS ErrorNumber, 
		ERROR_MESSAGE() AS ErrorMessage; 
		commit 
		return 0;
		end catch
	end;
GO
/****** Object:  StoredProcedure [dbo].[TB_Item_Save]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TB_Item_Save]
(
	@ItemGuid uniqueidentifier,
    @ItemCode int,
    @ItemName nvarchar(50),
    @ParentGuid uniqueidentifier,
	@itemPrice as decimal(10, 2),
	@itemPriceSingle as decimal(10, 2),
	@itemPriceMany as decimal(10, 2),
	@IsGroup bit
)
AS
BEGIN
set nocount on;
begin try
begin tran
   
    if (@ParentGuid = 0x0 or @ParentGuid is null) and (@IsGroup = 0) 
	begin
		commit tran;
		print'cant insert this infomation';
		rollback;
	end;

	IF @ItemGuid IS NULL
    BEGIN
        SET @ItemGuid = NEWID();

		if (@ParentGuid is null or @ParentGuid =0x00) and (@IsGroup = 1)
			begin	
				INSERT INTO TB_Item (ItemGuid, ItemCode, ItemName, ParentGuid, itemPrice,itemPriceSingle,itemPriceMany,IsGroup)
					VALUES (@ItemGuid, @ItemCode, @ItemName, 0x00, @itemPrice, @itemPriceSingle, @itemPriceMany, @IsGroup);
					commit tran;
					return 1;
				end;

		else if (@ParentGuid is not null or @ParentGuid !=0x00) and (@IsGroup = 1)
			begin 
			declare @flage int = 0;
				SELECT @flage = 1
				FROM TB_Item P
				LEFT JOIN TB_Item C ON p.ItemGuid = C.ParentGuid
				WHERE P.ParentGuid = @ParentGuid and p.Isgroup = 1; 
			
			if @flage = 1
				begin
					INSERT INTO TB_Item (ItemGuid, ItemCode, ItemName, ParentGuid, IsGroup)
					VALUES (@ItemGuid, @ItemCode, @ItemName, @ParentGuid, @IsGroup);
					commit tran;
					return 1;
				end;
			end;
		else 
			begin
				INSERT INTO TB_Item (ItemGuid, ItemCode, ItemName, ParentGuid, IsGroup)
					VALUES (@ItemGuid, @ItemCode, @ItemName, @ParentGuid, @IsGroup);
					commit tran;
					return 1;
			end;
		end;
   
   -- update
	
	else 
		begin
			DECLARE @itemcheck INT =0;
			EXEC checkParent @ItemGuid, @ParentGuid, @itemcheck OUTPUT;
			IF @itemcheck = 1
				BEGIN
					PRINT 'cant update';
                    RETURN 0;
                END

			ELSE BEGIN
                 	UPDATE TB_Item 
					SET ItemGuid = @ItemGuid
					   ,Itemcode = @ItemCode
					   ,ItemName = @ItemName
					   ,ParentGuid = @ParentGuid
					   ,Isgroup = @IsGroup,
					   itemPrice =@itemPrice,
					   itemPriceSingle = @itemPriceSingle,
					   itemPriceMany = @itemPriceMany
					WHERE ItemGuid = @ItemGuid;
                 END;
				PRINT 'update done';
	RETURN 1;
		end;
end try

begin catch
	SELECT
		ERROR_NUMBER() AS ErrorNumber,
		ERROR_MESSAGE() AS ErrorMessage; 
		commit tran;
		return 0;
end catch
set nocount off;
END;
GO
/****** Object:  StoredProcedure [dbo].[TB_Item_Save1]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TB_Item_Save1]
    @guid AS UNIQUEIDENTIFIER = 0x0 OUTPUT,
    @itemcode AS INT,
    @itemname AS NVARCHAR(100),
    @itemPrice AS DECIMAL(10, 2),
    @itemPriceSingle AS DECIMAL(10, 2),
    @itemPriceMany AS DECIMAL(10, 2),
    @ParentGUID UNIQUEIDENTIFIER = NULL,
    @ISGroup BIT = 0
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Check if the parent item exists
        IF @ParentGUID IS NULL
        BEGIN
		set @guid = NEWID();
            -- Insert a new parent item
            INSERT INTO TB_Item
                (itemGuid, itemcode, itemName, itemPrice, itemPriceSingle, itemPriceMany, parentGuid, ISGroup)
            VALUES
                (NEWID(), @itemcode, @itemname, @itemPrice, @itemPriceSingle, @itemPriceMany, newID(), @ISGroup);
        END
        ELSE
        BEGIN
            -- Check if the parent item exists
            IF EXISTS (SELECT 1 FROM TB_Item WHERE parentGuid = @ParentGUID)
            BEGIN
                -- Insert a child item
                SET @guid = NEWID();
                INSERT INTO TB_Item
                    (itemGuid, itemcode, itemName, itemPrice, itemPriceSingle, itemPriceMany, parentGuid, ISGroup)
                VALUES
                    (NEWID(), @itemcode, @itemname, @itemPrice, @itemPriceSingle, @itemPriceMany, @ParentGUID, 0);
            END
            ELSE
            BEGIN
				set @guid = NEWID();
                -- Parent item doesn't exist, so insert it as a parent
                INSERT INTO TB_Item
                    (itemGuid, itemcode, itemName, itemPrice, itemPriceSingle, itemPriceMany, parentGuid, ISGroup)
                VALUES
                    (NEWID(), @itemcode, @itemname, @itemPrice, @itemPriceSingle, @itemPriceMany, NEWID(), 1);
            END;
        END;

        PRINT('INSERT DONE');
        COMMIT;
        RETURN 1;
    END TRY
    BEGIN CATCH
        SELECT
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage;
        ROLLBACK;
        RETURN 0;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[TB_Stock_Delete]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TB_Stock_Delete]
	@guid as UNIQUEIDENTIFIER

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	delete from TB_StockItem where itemGuid = @guid;
    


END
GO
/****** Object:  StoredProcedure [dbo].[TB_Stock_Get]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TB_Stock_Get]
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from TB_StockItem;
END
GO
/****** Object:  StoredProcedure [dbo].[TB_Stock_Update_Calcutor]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TB_Stock_Update_Calcutor]
	@guid as uniqueidentifier = 0x0
AS
begin

	begin try 
		
		BEGIN TRANSACTION;

			IF EXISTS (SELECT 1
	FROM TB_StockItem
	WHERE itemGuid = @guid)
			BEGIN
		SELECT (A.Quintity - B.Quintity) AS 'TOTAL STOCK'
		FROM TB_StockItem A JOIN TB_StockItem B
			ON A.itemGuid = B.itemGuid
		WHERE A.itemGuid = @GUID AND (A.status = 'IN'AND B.status = 'OUT');
		COMMIT;
		RETURN 1;
	END
			ELSE 
			BEGIN
		SELECT TB_Item.itemcode , TB_ITEM.itemName, (A.Quintity - B.Quintity)  AS 'TOTAL STOCK'
		FROM TB_StockItem A JOIN TB_StockItem B
			ON A.itemGuid = B.itemGuid JOIN TB_Item
			ON A.itemGuid = TB_Item.itemGuid
		WHERE A.status = 'IN'AND B.status = 'OUT';
			COMMIT;
			RETURN 1;
	END;


	end try
	
	begin catch
		SELECT
		ERROR_NUMBER() AS ErrorNumber,
		ERROR_MESSAGE() AS ErrorMessage; 
		commit;
		return 0;
		end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[TB_StockItem_Save]    Script Date: 10/7/2023 4:35:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TB_StockItem_Save]
    @Guid AS UNIQUEIDENTIFIER,
    @Status AS NVARCHAR(10),
    @Quin AS INT
AS
BEGIN
SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;

        IF EXISTS (SELECT 1 FROM TB_Item WHERE itemGuid = @GUID)
        BEGIN
            SELECT @Status = UPPER(@STATUS);

            IF NOT EXISTS (SELECT 1 FROM TB_StockItem WHERE itemGuid = @Guid)
            BEGIN
			IF	@Status = 'IN'
			BEGIN
                INSERT INTO TB_StockItem
                VALUES (@Guid, @Status, @Quin);

                INSERT INTO TB_StockItem
                VALUES (@Guid, 'OUT', 0);

                COMMIT tran;
                RETURN 1;
            END;
			else begin
				INSERT INTO TB_StockItem
                VALUES (@Guid, @Status, @Quin);

                INSERT INTO TB_StockItem
                VALUES (@Guid, 'IN', 0);
				 COMMIT tran;
                RETURN 1;
			end;
			end;
            ELSE
			begin
			IF @Status = 'IN'
            BEGIN
                UPDATE TB_StockItem SET Quintity = Quintity + @Quin
                WHERE itemGuid = @GUID AND status = 'IN';

                COMMIT tran;
                RETURN 1;
            END;
            ELSE IF @Status = 'OUT'
            BEGIN
                UPDATE TB_StockItem SET Quintity = Quintity + @Quin
                WHERE itemGuid = @GUID AND status = 'OUT';

                COMMIT tran;
                RETURN 1;
            END;
        END;

		end;
    END TRY
    BEGIN CATCH
        SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_MESSAGE() AS ErrorMessage;
        ROLLBACK;
        RETURN 0;
    END CATCH;
END;
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TB_Billitems"
            Begin Extent = 
               Top = 40
               Left = 462
               Bottom = 241
               Right = 632
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TB_Bill"
            Begin Extent = 
               Top = 38
               Left = 85
               Bottom = 208
               Right = 240
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TB_Item"
            Begin Extent = 
               Top = 56
               Left = 890
               Bottom = 257
               Right = 1061
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 960
         Width = 825
         Width = 945
         Width = 1035
         Width = 885
         Width = 585
         Width = 1980
         Width = 795
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_SHOW'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_SHOW'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TB_Item"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TB_StockItem"
            Begin Extent = 
               Top = 6
               Left = 247
               Bottom = 119
               Right = 417
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Show_stock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Show_stock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TB_StockItem"
            Begin Extent = 
               Top = 96
               Left = 52
               Bottom = 209
               Right = 222
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TB_Item"
            Begin Extent = 
               Top = 64
               Left = 397
               Bottom = 194
               Right = 568
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Stock_Item'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Stock_Item'
GO
USE [master]
GO
ALTER DATABASE [Bills] SET  READ_WRITE 
GO

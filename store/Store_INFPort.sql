USE INFPortObject
GO

CREATE PROC [dbo].[fpt_sp_Get_Tacit_All]
AS
BEGIN
	SELECT * FROM Tacit(NOLOCK)
END


GO

CREATE PROC [dbo].[fpt_sp_Get_Tacit_Paging] 
@Keyword VARCHAR(50),
@PageIndex INT,
@PageSize INT
AS
BEGIN
	SELECT * FROM Tacit(NOLOCK) WHERE (@Keyword IS NULL OR Name LIKE @Keyword + '%') ORDER BY Name DESC
	offset (@PageIndex - 1) * @PageSize rows
	fetch next @PageSize row only
END
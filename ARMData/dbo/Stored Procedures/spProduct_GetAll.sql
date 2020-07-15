CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
begin
    set nocount on;

    select Id, ProductName, [Discription], RetailPrice, QuantityInStock, IsTaxable
    from dbo.Product
    order by ProductName;
end

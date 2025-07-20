WITH RankedProducts AS (
    SELECT *, ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
)
SELECT * FROM RankedProducts
WHERE RowNum <= 3;

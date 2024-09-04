select	ProductName, CategoryName
from ProductCategory full join ProductTable on ProductCategory.id_product = ProductTable.id_product left join CategoryTable on ProductCategory.id_category = CategoryTable.id_category

namespace _04.AddNewProduct
{
    using System;
    using System.Data.SqlClient;

    internal static class AddNewProduct
    {
        private static void Main()
        {
            SqlConnection dbCon = new SqlConnection(
                "Server=.\\SQLEXPRESS;" +
                "Database=Northwind;" +
                "Integrated Security=true");

            dbCon.Open();

            using (dbCon)
            {
                int latestProduct = InsertProductInDatabase(dbCon, "Golf Ball Markers", 1, 1, "10 x 10", 10, 1000, 10, 50, false);

                Console.WriteLine("Product with Id:{0} inserted successfully.", latestProduct);
            }
        }

        private static int InsertProductInDatabase(
            SqlConnection dbCon,
            string productName,
            int supplierId,
            int categoryId,
            string quantityPerUnit,
            decimal unitPrice,
            int unitsInStock,
            int unitsOnOrder,
            int reorderLevel,
            bool discontinued)
        {
            string sqlStringCommand = @"
                    INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder,ReorderLevel, Discontinued)
                    VALUES (@productName, @supplierID, @categoryID, @quantityPerUnit, @nitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)";

            SqlCommand insertProduct = new SqlCommand(sqlStringCommand, dbCon);
            insertProduct.Parameters.AddWithValue("@productName", productName);
            insertProduct.Parameters.AddWithValue("@supplierID", supplierId);
            insertProduct.Parameters.AddWithValue("@categoryID", categoryId);
            insertProduct.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            insertProduct.Parameters.AddWithValue("@nitPrice", unitPrice);
            insertProduct.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            insertProduct.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
            insertProduct.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            insertProduct.Parameters.AddWithValue("@discontinued", discontinued);

            insertProduct.ExecuteNonQuery();

            SqlCommand cmdSelectIdentity = new SqlCommand("SELECT @@Identity", dbCon);
            int insertedRecordId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();
            return insertedRecordId;
        }
    }
}
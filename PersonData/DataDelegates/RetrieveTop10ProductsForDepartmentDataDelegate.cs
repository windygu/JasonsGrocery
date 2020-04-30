﻿using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DepartmentData.DataDelegates
{
   internal class RetrieveTop10ProductsForDepartmentDataDelegate : DataReaderDelegate<IReadOnlyList<Product>>
   {
      private readonly int departmentID;

      public RetrieveTop10ProductsForDepartmentDataDelegate(int departmentID)
         : base("Stores.Top10Products") //name of procedure
      {
            this.departmentID = departmentID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.AddWithValue("DepartmentID", departmentID);
         //p.Value = departmentID;
        }
      
      public override IReadOnlyList<Product> Translate(SqlCommand command, IDataRowReader reader)
      {
         var Products = new List<Product>();

         while (reader.Read())
         {
                //product just product id and name (match with select in query)
                Products.Add(new Product(
                    reader.GetInt32("QuantitySold"),
                    reader.GetString("ProductName")
                    ));
         }

         return Products;
      }
   }
}
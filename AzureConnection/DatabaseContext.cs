using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Company.Function
{
     public class DatabaseContext
    {
        private readonly string connectionString;
        

        public DatabaseContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Skin GetSkins(string name, string exterior)
        {
            Skin skin = new Skin();
            string Query = $"Select * from SkinsPrices where name = '{name}' and exterior = '{exterior}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    skin = new Skin
                    {
                        Name = reader["Name"].ToString(),
                        Exterior = reader["Exterior"].ToString(),
                        ImageUrl = reader["ImageUrl"].ToString(),
                        bitskins = reader["bitskins"].ToString(),
                        csmoney = reader["csmoney"].ToString(),
                        csgotm = reader["csgotm"].ToString(),
                        csgoexo = reader["csgoexo"].ToString(),
                        swapgg = reader["swapgg"].ToString(),
                        skinport = reader["skinport"].ToString(),
                        dmarket = reader["dmarket"].ToString(),
                        vmarket = reader["vmarket"].ToString(),
                        waxpeer = reader["waxpeer"].ToString()
                    };
                }   
                reader.Close();
            }
            return skin;
        }


    }
}
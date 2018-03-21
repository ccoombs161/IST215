using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_StoredProcedureUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (SqlConnection con = new SqlConnection(conString))
            {
                conn.Open(); //this was missing

                using (SqlCommand cmd = new SqlCommand("administratorUpdate", con))
                {
                    cmd.Parameters.Add("@originalID", SqlDbType.VarChar).Value = IDHF.Value;
                    cmd.Parameters.Add("@firstName", SqlDbType.VarChar).Value = firstNameTB.Text;
                    cmd.Parameters.Add("@lastName", SqlDbType.VarChar).Value = lastNameTB.Text;
                    cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = userNameTB.Text;
                    cmd.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = emailAddressTB.Text;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery(); //this was missing.
                }

                conn.Close();
            }
    */
        }

    }
}
/*
 ALTER PROCEDURE [dbo].[administratorUpdate]
    @originalID UNIQUEIDENTIFIER,
    @firstName varchar (100),
    @lastName varchar (100),
    @userName varchar (100),
    @emailAddress varchar (100),
    @password varchar (100),
    @isActive bit
AS

UPDATE administrator
SET userName = @userName,
    emailAddress = @emailAddress,
    password = @password,
    firstName = @firstName,
    lastName = @lastName,
    isActive = @isActive
WHERE
    ID = @originalID
*/
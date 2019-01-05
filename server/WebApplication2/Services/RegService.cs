using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using WebApplication2.RegRequest;

namespace WebApplication2.Services
{
	public class RegService
	{
		string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

		//Get all---------
		public List<RegModel> GetAll()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{

				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandText = "Registration_SELECTALL";
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					List<RegModel> regList = new List<RegModel>();
					while (reader.Read())

					{
						RegModel register = new RegModel
						{
							id = (int)reader["id"],
							FirstName = (string)reader["firstName"],
							LastName = (string)reader["lastName"],
							Interests = (string)reader["interests"],
							Skills = (string)reader["skills"]
						};

						regList.Add(register);

					}
					return regList;
				}
			}
		}
		//create new record
		public int Create(CreateRegRequest request)
		{

			using (SqlConnection con = new SqlConnection(connectionString))
			{

				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandText = "Registration_INSERT";
				cmd.CommandType = System.Data.CommandType.StoredProcedure;


				cmd.Parameters.AddWithValue("@firstName", request.FirstName);
				cmd.Parameters.AddWithValue("@lastName", request.LastName);
				cmd.Parameters.AddWithValue("@interests", request.Interests);
				cmd.Parameters.AddWithValue("@skills", request.Skills);

				//output
				cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

				cmd.ExecuteNonQuery();

				int newId = (int)cmd.Parameters["@id"].Value;
				return newId;
			}
		}
	}
}
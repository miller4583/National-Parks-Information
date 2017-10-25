using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Capstone.Web.Dal
{
    public class ParkSqlDAL : IParkDAL
    {
        private string ProductConnectionString = ConfigurationManager.ConnectionStrings["park"].ConnectionString;
        private const string Get_All_Parks = "Select * from park;";
        private const string Get_Park = "Select * from park where park.ParkCode = @parkID;";

        public List<Park> GetAllParks()
        {
            List<Park> output = new List<Park>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ProductConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(Get_All_Parks, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Park p = new Park();
                        p.ParkCode = Convert.ToString(reader["parkCode"]);
                        p.ParkName = Convert.ToString(reader["parkName"]);
                        p.State = Convert.ToString(reader["state"]);
                        p.Acreage = Convert.ToInt32(reader["acreage"]);
                        p.ElevationInFeet = Convert.ToInt32(reader["elevationInFeet"]);
                        p.MilesOfTrail = Convert.ToDouble(reader["milesOfTrail"]);
                        p.NumberOfCampSites = Convert.ToInt32(reader["numberOfCampsites"]);
                        p.Climate = Convert.ToString(reader["climate"]);
                        p.YearFounded = Convert.ToInt32(reader["yearFounded"]);
                        p.AnnualVistors = Convert.ToInt32(reader["annualVisitorCount"]);
                        p.Quote = Convert.ToString(reader["inspirationalQuote"]);
                        p.QuoteSource = Convert.ToString(reader["inspirationalQuoteSource"]);
                        p.Description = Convert.ToString(reader["parkDescription"]);
                        p.EntryFee = Convert.ToDouble(reader["entryFee"]);
                        p.AnimalSpecies = Convert.ToInt32(reader["numberOfAnimalSpecies"]);
                        output.Add(p);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return output;
        }



        public Park GetPark(string parkID)
        {
            Park p = new Park();
            try
            {
                using (SqlConnection conn = new SqlConnection(ProductConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(Get_Park, conn);
                    cmd.Parameters.AddWithValue("@parkID", parkID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        p.ParkCode = Convert.ToString(reader["parkCode"]);
                        p.ParkName = Convert.ToString(reader["parkName"]);
                        p.State = Convert.ToString(reader["state"]);
                        p.Acreage = Convert.ToInt32(reader["acreage"]);
                        p.ElevationInFeet = Convert.ToInt32(reader["elevationInFeet"]);
                        p.MilesOfTrail = Convert.ToDouble(reader["milesOfTrail"]);
                        p.NumberOfCampSites = Convert.ToInt32(reader["numberOfCampsites"]);
                        p.Climate = Convert.ToString(reader["climate"]);
                        p.YearFounded = Convert.ToInt32(reader["yearFounded"]);
                        p.AnnualVistors = Convert.ToInt32(reader["annualVisitorCount"]);
                        p.Quote = Convert.ToString(reader["inspirationalQuote"]);
                        p.QuoteSource = Convert.ToString(reader["inspirationalQuoteSource"]);
                        p.Description = Convert.ToString(reader["parkDescription"]);
                        p.EntryFee = Convert.ToDouble(reader["entryFee"]);
                        p.AnimalSpecies = Convert.ToInt32(reader["numberOfAnimalSpecies"]);
                        
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return p;
        }
    }
}
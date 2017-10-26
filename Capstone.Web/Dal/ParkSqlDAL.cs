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
        private const string Get_Park = "Select * from park join weather on park.parkcode = weather.parkcode where park.ParkCode = @parkID;";
        private const string SQL_Weather = "Select * from weather where weather.parkCode = @parkCode;";


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

                        p.FiveDayForecastValue = Convert.ToInt32(reader["fiveDayForecastValue"]);
                        p.Low = Convert.ToInt32(reader["low"]);
                        p.High = Convert.ToInt32(reader["high"]);
                        p.Forecast = Convert.ToString(reader["forecast"]);

                        
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return p;
        }


        public List<WeatherModel> Weather(string ParkCode)
        {
            List<WeatherModel> weather = new List<WeatherModel>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ProductConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_Weather, conn);
                    cmd.Parameters.AddWithValue("@parkCode", ParkCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        WeatherModel w = new WeatherModel();
                        w.ParkCode = Convert.ToString(reader["parkCode"]);
                        w.FiveDayForecastValue = Convert.ToInt32(reader["fiveDayForecastValue"]);
                        w.Low = Convert.ToInt32(reader["low"]);
                        w.High = Convert.ToInt32(reader["high"]);
                        w.Forecast = Convert.ToString(reader["forecast"]);
                        weather.Add(w);
                    }
                }
            }
            catch
            {
                throw;
            }
            return weather;
        }
    }
}
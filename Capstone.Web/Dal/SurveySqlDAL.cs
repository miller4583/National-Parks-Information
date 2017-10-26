using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Configuration;

using System.Data.SqlClient;
using System.Web.Mvc;

namespace Capstone.Web.Dal
{
    public class SurveySqlDAL : ISurveyDAL
    {
        private string ProductConnectionString = ConfigurationManager.ConnectionStrings["park"].ConnectionString;
        private const string Insert_Survey = "INSERT INTO survey_result VALUES(@parkCode, @emailAddress ,@state ,@activitLevel);";
        private const string Get_Surveys = "select count(survey_result.parkCode) as total, park.parkName, park.parkCode  from survey_result join park on park.parkCode = survey_result.parkCode group by park.parkName, park.parkCode order by parkName;";
        private const string Get_Drop_List = "select park.parkCode, park.parkName from park;";

        public void InsertSurvey(Survey s)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ProductConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(Insert_Survey, conn);
                    cmd.Parameters.AddWithValue("@parkCode", s.ParkCode);
                    cmd.Parameters.AddWithValue("@emailAddress", s.Email);
                    cmd.Parameters.AddWithValue("@state", s.State);
                    cmd.Parameters.AddWithValue("@activitLevel", s.ActivityLevel);
                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }


        public List<Survey> GetAllSurveys()
        {
            List<Survey> output = new List<Survey>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ProductConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(Get_Surveys, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Survey h = new Survey();

                        h.ParkCode = Convert.ToString(reader["parkCode"]);
                        h.ParkName = Convert.ToString(reader["parkName"]);
                        h.Total = Convert.ToInt32(reader["total"]);

                        output.Add(h);
                    }


                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return output;
        }

        public List<SelectListItem> GetList()
        {
            List<SelectListItem> output = new List<SelectListItem>();
            try
            {

                using (SqlConnection conn = new SqlConnection(ProductConnectionString ))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(Get_Drop_List, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        SelectListItem s = new SelectListItem();
                        s.Text = Convert.ToString(reader["parkName"]);
                        s.Value = Convert.ToString(reader["parkCode"]);
                        output.Add(s);

                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return output;
        }
    }
}
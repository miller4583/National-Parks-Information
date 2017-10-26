using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Web.Models;
using System.Web.Mvc;

namespace Capstone.Web.Dal
{
    public interface ISurveyDAL
    {
        List<Survey> GetAllSurveys();
        void InsertSurvey(Survey s);
        List<SelectListItem> GetList();

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Web.Models;

namespace Capstone.Web.Dal
{
    public interface ISurveyDAL
    {
        List<Survey> GetAllSurveys();
        void InsertSurvey(Survey s);

    }
}
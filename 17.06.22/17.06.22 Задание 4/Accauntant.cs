﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._06._22_Задание_4
{
    class Accauntant
    {
        public static bool AskForBonus(Employees postWorker, int hours)
        {
            if (hours >= (int)postWorker)
                return true;
            else
                return false;
        }
    }
    public enum Employees
    {
        ChiefExecutiveOfficer = 140,
        ChiefTechnologyOfficer = 130,
        JuniorDeveloper = 50,
        MiddleDeveloper = 70,
        SeniorDeveloper = 90,
        QualityAssuranceEngineers = 110
    }
}


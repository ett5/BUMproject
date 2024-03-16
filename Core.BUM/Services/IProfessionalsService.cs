﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;

namespace Core.BUM.Services
{
    public interface IProfessionalsService
    {
        public List<Professionals> GetProfessionals();
        public List<Professionals> GetProfessionalsByType(String type);//לשלוח לפונקיצה משתנה מסוג סטרינג של סוגי ההתמקצעות
        public Professionals GetProfessional(int id);
        public void Delete(int id);
        public Professionals Put(Professionals Professional);
        public Professionals Post(Professionals NewProfessional);
    }
}

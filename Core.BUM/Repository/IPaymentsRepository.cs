﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;


namespace Core.BUM.Repository
{
    public interface IPaymentsRepository
    {
        public List<Neighbors> GetPayNeighbors();//שכנים ששילמו
        public List<Neighbors> GetUnPayNeighbors();//שכנים שלא שילמו
        public List<Payments> Put(Neighbors NewNeighbor);//כל חודש יש לכל שכן שורה ומתעדכן אמצעי תשלום ושדה בוליאני
        public Payments Post(Payments NewPayment);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;


namespace Core.BUM.Services
{
    public interface IMessagesService
    {
        public List<Messages> GetMessages();
        public List<Messages> GetMessagesByDate(DateTime Date);//מחזיר את ההודעות של תאריך מסוים
        public List<Messages> GetMessagesUntilDate(DateTime Date);//מחזיר את ההודעות עד תאריך מסוים
        public List<Messages> GetMessagesBetweenDates(DateTime Start, DateTime End);//מחזיר את התווך מתאריך עד תאריך מסוים
        public List<Messages> GetMessagesFromDate(DateTime Date);//מחזיר את ההודעות מתאריך מסוים 
        public List<Messages> GetMassageesFromNeighbor(Neighbors neighbor);//לקבל הודעות משכן מסויםם 
        public List<Messages> GetMassageesToNeighbor(Neighbors neighbor);
        public Messages Post(Messages newMessage);
    }
}

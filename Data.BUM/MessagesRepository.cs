

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Repository;

using Core.BUM.Entitis;

namespace Data.BUM
{
    public class MessagesRepository : IMessagesRepository
    {
        private readonly DataContexst _DataContexst;
         public MessagesRepository (DataContexst DataContexst)
        {
            _DataContexst = DataContexst;
        }

        public List<Messages> GetMassageesFromNeighbor(Neighbors neighbor)
        {
            return _DataContexst.MessagesList.Where(a => a.From.Id == neighbor.Id).ToList();
        }

        public List<Messages> GetMassageesToNeighbor(Neighbors neighbor)
        {
            return _DataContexst.MessagesList.Where(a => a.To.Id == neighbor.Id).ToList();

        }

        public List<Messages> GetMessages()
        {
            return _DataContexst.MessagesList.ToList();

        }

        public List<Messages> GetMessagesBetweenDates(DateTime Start, DateTime End)
        {
            return _DataContexst.MessagesList.Where(a=>a.Start>=Start&& a.End<=End).ToList();
        }

        public List<Messages> GetMessagesByDate(DateTime Date)
        {
            return _DataContexst.MessagesList.Where(a => a.Start >= Date && a.End <= Date).ToList();
        }

        public List<Messages> GetMessagesFromDate(DateTime Date)
        {
            return _DataContexst.MessagesList.Where(a => a.Start >= Date).ToList();
        }

        public List<Messages> GetMessagesUntilDate(DateTime Date)
        {
            return _DataContexst.MessagesList.Where(a => a.End<= Date).ToList();
        }

        public Messages Post(Messages newMessage)
        {
           _DataContexst.MessagesList.Add(newMessage);
            _DataContexst.SaveChanges();
            return newMessage;
        }
    }
}

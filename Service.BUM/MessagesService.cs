
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.BUM.Entitis;
using Core.BUM.Services;
using Core.BUM.Repository;

namespace Service.BUM
{
    public class MessagesService : IMessagesService
    {
        private readonly IMessagesRepository _MessagesRepository;
        public MessagesService(IMessagesRepository  MessagesRepository)
        {
            _MessagesRepository =  MessagesRepository;
        }

        public List<Messages> GetMassageesFromNeighbor(Neighbors neighbor)
        {
            return _MessagesRepository.GetMassageesFromNeighbor(neighbor);      }

        public List<Messages> GetMassageesToNeighbor(Neighbors neighbor)
        {
            return _MessagesRepository.GetMassageesToNeighbor(neighbor);
        }
    



    public List<Messages> GetMessages()
        {
           return _MessagesRepository.GetMessages();
        }

        public List<Messages> GetMessagesBetweenDates(DateTime Start, DateTime End)
        {
            return _MessagesRepository.GetMessagesBetweenDates(Start, End);  
                }

        public List<Messages> GetMessagesByDate(DateTime Date)
        {
            return _MessagesRepository.GetMessagesByDate(Date);       }

        public List<Messages> GetMessagesFromDate(DateTime Date)
        {
            return _MessagesRepository.GetMessagesFromDate(Date);
        }

        public List<Messages> GetMessagesUntilDate(DateTime Date)
        {
            return _MessagesRepository.GetMessagesUntilDate(Date);       }

        public Messages Post(Messages newMessage)
        {
            return _MessagesRepository.Post(newMessage);        
        }
    }
}

﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _message2Dal;
        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _message2Dal.GetInboxWithMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetSendboxListByWriter(int id)
        {
            return _message2Dal.GetSendboxWithMessageByWriter(id);
        }

        public void TAdd(Message2 t)
        {
            _message2Dal.Insert(t);
        }


        public void TDelete(Message2 entity)
        {
            throw new NotImplementedException();
        }



        public Message2 TGetById(int id)
        {
            return _message2Dal.GetByID(id);
        }

        public void TUpdate(Message2 entity)
        {
            _message2Dal.Update(entity);
        }
    }
}
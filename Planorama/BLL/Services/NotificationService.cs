using AutoMapper;
using BLL.DTO;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NotificationService
    {
        public static List<NotificationDTO> Get()
        {
            var data = DataAccessFactory.NotificationData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Notification, NotificationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<NotificationDTO>>(data);
            return mapped;
        }

        public static NotificationDTO Get(int id)
        {
            var data = DataAccessFactory.NotificationData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Notification, NotificationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<NotificationDTO>(data);
            return mapped;
        }
    }
}

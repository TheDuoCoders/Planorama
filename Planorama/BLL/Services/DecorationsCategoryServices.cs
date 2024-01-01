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
    public class DecorationsCategoryServices
    {
        public static List<DecorationsCategoryDTO> Get()
        {
            var data = DataAccessFactory.DecorationsCategoryData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DecorationsCategory, DecorationsCategoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DecorationsCategoryDTO>>(data);
            return mapped;
        }

        public static DecorationsCategoryDTO Get(int id)
        {
            var data = DataAccessFactory.DecorationsCategoryData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DecorationsCategory, DecorationsCategoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DecorationsCategoryDTO>(data);
            return mapped;

        }
    }
}

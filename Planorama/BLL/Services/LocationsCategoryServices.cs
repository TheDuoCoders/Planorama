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
    public class LocationsCategoryServices
    {
        public static List<LocationsCategoryDTO> Get()
        {
            var data = DataAccessFactory.LocationsCategoryData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<LocationsCategory, LocationsCategoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<LocationsCategoryDTO>>(data);
            return mapped;
        }

        public static LocationsCategoryDTO Get(int id)
        {
            var data = DataAccessFactory.LocationsCategoryData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<LocationsCategory, LocationsCategoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<LocationsCategoryDTO>(data);
            return mapped;

        }
    }
}

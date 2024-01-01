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
    public class PackageService
    {
        public static List<PackageDTO> Get()
        {
            var data = DataAccessFactory.PackageData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PackageDTO>>(data);
            return mapped;
        }

        public static PackageDTO Get(int id)
        {
            var data = DataAccessFactory.PackageData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PackageDTO>(data);
            return mapped;
        }
    }
}

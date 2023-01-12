using System;
using ReadMoreApi.APIModels;
using ReadMoreApi.DBModels;

namespace ReadMoreApi.Services
{
    public class AutoMapping : AutoMapper.Profile
    {
        public AutoMapping()
        {
            CreateMap<DateTime, DateOnly>().ConvertUsing(dt => DateOnly.FromDateTime(dt));
            CreateMap<DateOnly, DateTime>().ConvertUsing(dateOnly => dateOnly.ToDateTime(new TimeOnly(0,0)));

            CreateMap<User, DBUser>().ReverseMap();
        }
    }
}

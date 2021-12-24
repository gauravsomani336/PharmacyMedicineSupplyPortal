using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProj.Models;

namespace WebProj.Repository
{
    public interface ISchedule
    {
        public Task<List<Schedule>> CreateSchedule(DateTime date);
    }
}

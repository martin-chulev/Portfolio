using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public interface IPersonalInfoService
    {
        public PersonalInfo GetPersonalInfo();
    }
}

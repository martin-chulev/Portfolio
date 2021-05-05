using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Portfolio.Services
{
    public class PersonalInfoService : IPersonalInfoService
    {
        public PersonalInfo GetPersonalInfo()
        {
            if (File.Exists(Constants.URLs.PersonalInfoFilePath) == false)
                return new PersonalInfo();

            var personalInfoJson = File.ReadAllText(Constants.URLs.PersonalInfoFilePath);
            return JsonConvert.DeserializeObject<PersonalInfo>(personalInfoJson);
        }
    }
}

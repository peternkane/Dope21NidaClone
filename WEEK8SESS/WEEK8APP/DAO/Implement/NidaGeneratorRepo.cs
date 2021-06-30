using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEEK8APP.DAO.Interface;
using WEEK8APP.DATABASE;
using WEEK8APP.DTO;

namespace WEEK8APP.DAO.Implement
{
    public class NidaGeneratorRepo : INidaGenerator
    {
        private readonly Random random = new Random();

        public string Generate()
        {
            var limit = 9;

            var randomString = limit.ToString();

            for (int i = 0; i <  limit; i++)
            {
                

                randomString += random.Next(0, 9);
            }

            return randomString;
        }
    }
}

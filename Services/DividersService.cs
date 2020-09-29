using Localiza.Challange.Dividers.Models;
using Localiza.Challange.Dividers.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Challange.Dividers.Services
{
    public class DividersService : IDividersService
    {
        public ResponseDividers GetDividers(int number)
        {
            var allDividers = GetAllDividers(number);

            return new ResponseDividers()
            {
                AllDividers = allDividers,
                PrimeDividers = GetPrimeNumbers(allDividers),
                FoundAnswer = allDividers.Count > 1
            };
        }


        private List<int> GetAllDividers(int number)
        {
            var result = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private List<int> GetPrimeNumbers(List<int> numbers)
        {
            var result = new List<int>();

            foreach (var number in numbers)
            {
                if (GetAllDividers(number).Count == 2)
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}

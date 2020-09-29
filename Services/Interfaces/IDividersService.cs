using Localiza.Challange.Dividers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Challange.Dividers.Services.Interfaces
{
    public interface IDividersService
    {
        ResponseDividers GetDividers(int number);
    }
}

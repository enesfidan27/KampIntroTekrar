using GameProject.Nesneler;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Soyutlar
{
    interface IValidationService
    {
        bool Validate(Gamer gamer);
    }
}

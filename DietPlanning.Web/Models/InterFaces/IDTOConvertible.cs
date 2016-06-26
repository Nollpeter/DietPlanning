using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanning.Mobile.DTO;

namespace DietPlanning.Web.Models.InterFaces
{
    public interface IDTOConvertible
    {
        T ToDTO<T>() where T : IDTO, new();
    }
}

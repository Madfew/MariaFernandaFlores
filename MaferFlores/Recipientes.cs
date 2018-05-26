using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaferFlores
{
    class Recipientes : Utensilios
    {
        Utensilios utensilios = new Utensilios();
        

        public float profundidad;

        public Recipientes(float profundidad, string tamaño, string material)
        {
            this.profundidad = profundidad;
            utensilios.tamaño = tamaño;
            utensilios.material = material;
        }

        public void contener()
        {

        }
    }
}

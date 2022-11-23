using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class EMPLEADO
    {
        DAL.MP_EMPLEADO mp = new DAL.MP_EMPLEADO();
        public List<BE.EMPLEADO> Listar()
        {
            return mp.Listar();
        }

        public int Alta(BE.EMPLEADO EMPLEADO)
        {
            int resultado;
            resultado = mp.Insertar(EMPLEADO);
            return resultado;
        }

        public int Modificacion(BE.EMPLEADO EMPLEADO)
        {
            int resultado;
            resultado = mp.Editar(EMPLEADO);
            return resultado;
        }

        public int Borrar(BE.EMPLEADO EMPLEADO)
        {
            return mp.Borrar(EMPLEADO);
        }

        

	}
}
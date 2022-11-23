using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MP_EMPLEADO : MAPPER<BE.EMPLEADO>
    {
        public override int Borrar(BE.EMPLEADO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@id", entidad.Id)
            };
            acceso.Abrir();
            int res = acceso.Escribir("PERSONA_BORRAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override BE.EMPLEADO Convertir(DataRow registro)
        {
            BE.EMPLEADO EMPLEADO = new BE.EMPLEADO();
            EMPLEADO.Id = int.Parse(registro["ID"].ToString());
            EMPLEADO.Nombre = registro["nombre"].ToString();
            EMPLEADO.Apellido = registro["apellido"].ToString();
            EMPLEADO.SueldoBruto = float.Parse(registro["sueldoBruto"].ToString());
            return EMPLEADO;
        }

        public override int Editar(BE.EMPLEADO entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@id", entidad.Id),
                acceso.CrearParametro("@nom", entidad.Nombre),
                acceso.CrearParametro("@ape", entidad.Apellido),
                acceso.CrearParametro("@sueldo", entidad.SueldoBruto)
            };
            acceso.Abrir();
            int resultado = acceso.Escribir("PERSONA_EDITAR", parametros);
            acceso.Cerrar();
            return resultado;
        }

        public override int Insertar(BE.EMPLEADO emp)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@nom", emp.Nombre),
                acceso.CrearParametro("@ape", emp.Apellido),
                acceso.CrearParametro("@sueldo", emp.SueldoBruto)
            };
            acceso.Abrir();
            int res = acceso.Escribir("PERSONA_INSERTAR", parametros);
            acceso.Cerrar();
            return res;
        }

        public override List<BE.EMPLEADO> Listar()
        {
            acceso.Abrir();
            DataTable tabla = acceso.Leer("Empleado_Listar");
            acceso.Cerrar();

            List<BE.EMPLEADO> EMPLEADOS = new List<BE.EMPLEADO>();
            foreach (DataRow registro in tabla.Rows)
            {
                EMPLEADOS.Add(Convertir(registro));
            }
            return EMPLEADOS;
        }

    }
}
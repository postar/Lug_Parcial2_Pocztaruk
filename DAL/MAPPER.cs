using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public abstract class MAPPER<T>
    {
        internal Acceso acceso = new Acceso();
        public abstract int Insertar(T entidad);
        public abstract int Editar(T entidad);
        public abstract int Borrar(T entidad);
        public abstract List<T> Listar();
        public abstract T Convertir(DataRow registro);
    }
}
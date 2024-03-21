using SistemasExamen.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PersonaDAL
{
    public DataTable listarPersonaDAL()
    {
        string consulta = "select * from persona";
        DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
        return lista;
    }
}

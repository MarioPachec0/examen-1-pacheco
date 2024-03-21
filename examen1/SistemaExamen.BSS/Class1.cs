using System.Data;

namespace SistemaExamen.BSS
{
    public class PersonaBss
    {
        PersonaDAL dal =new PersonaDAL();
        public DataTable ListarPersonaBss() 
        { 
            return dal.listarPersonaDAL();
        }
    }
}
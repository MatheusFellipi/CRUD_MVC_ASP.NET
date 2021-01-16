using System.Linq;
using System.Threading.Tasks;


namespace MVC__CRUD_TESTE.Models
{
 
    public class Produtos
    {
        public int id { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public bool status { get; set; }

    }
}

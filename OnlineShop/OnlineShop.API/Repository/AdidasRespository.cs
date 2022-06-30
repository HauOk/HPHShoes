using OnlineShop.API.Interface;
using OnlineShop.API.Model;

namespace OnlineShop.API.Repository
{
    public class AdidasRespository : IAdidas
    {
        List<ModalAdidas> listProduct = new List<ModalAdidas>
        {
            new ModalAdidas{IdProduct=1, ProductName = "ao 1", Price = "10000" }
        };

        public List<ModalAdidas> GetAllAdidas()
        {
            return listProduct;
        }

        public ModalAdidas GetProduct(int id)
        {
            return listProduct.FirstOrDefault(i => i.IdProduct == id);
        }
    }
}

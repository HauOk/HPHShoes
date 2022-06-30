using OnlineShop.API.Model;

namespace OnlineShop.API.Interface
{
    public interface IAdidas
    {
        List<ModalAdidas> GetAllAdidas();
        ModalAdidas GetProduct(int id);
    }
}

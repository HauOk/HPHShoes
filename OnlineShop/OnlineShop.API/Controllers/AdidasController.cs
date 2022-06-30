using Microsoft.AspNetCore.Mvc;
using OnlineShop.API.Interface;
using OnlineShop.API.Repository;
using OnlineShop.API.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdidasController : ControllerBase
    {
        private IAdidas product = new AdidasRespository();

        [HttpGet]
        // localhost/category  GET
        //lay tat ca danh sach chuyen muc
        public ActionResult<IEnumerable<ModalAdidas>> GetAllCategory()
        {
            return product.GetAllCategory();
        }

        [HttpGet]
        // localhost/category/1 GET
        // Adidas/1 // lay chi tiet 1  chuyen muc theo id = 1
        public ActionResult<IEnumerable<ModalAdidas>> GetCategory(int id)
        {
            return product.GetCategory(id);
        }

        [HttpPost]
        // localhost/category POST 
        /*
         {
            name: "name chuyen muc",
            metaname: "meta name"
        }
        them 1 chuyen muc moi 
         */ 
        public ActionResult<IEnumerable<ModalAdidas>> AddProduct(string name, string metaname)
        {
            string status = category.addCategory(name, metaname);
            if (status)
            {
                return "{status: true}";
            }
            return "{status: false}";
        }

        [HttpPost]
        // localhost/category POST 
        /*
         {
            id : 1,
            name: "name chuyen muc",
            metaname: "meta name"
        }
        update 1 chuyen muc theo id 1 
         */
        public ActionResult<IEnumerable<ModalAdidas>> AddProduct(string id, string name, string metaname)
        {
            string status = category.editCategory(id, name, metaname);
            if (status)
            {
                return "{status: true}";
            }
            return "{status: false}";
        }

        [HttpDelete]
        /*
         * giong post ơ tren  
         * co dung pt post cũng dc
         */
        public ActionResult<IEnumerable<ModalAdidas>> AddProduct(int id)
        {
            string status = category.deleteCategory(id);
            if (status)
            {
                return "{status: true}";
            }
            return "{status: false}";
        }
        /*
         cac PT : xem, xem chi tiet, them, chinh sua, xoa
            admin :  tat ca PT,
            user : xem, xem chi tiet.

        vidu chuc nang cua users 
             cac PT : xem, xem chi tiet, them, chinh sua, xoa
             admin: tat ca pt tren
             user : xem chi tiet, chinh sua, 

        xu ly logic 
        1. trong project api ma co model thi xu ly o project nay luon. (project api)
         **** 2. trong project k co thu muc model dung ke thua tu project cha (website, sharedata...) 
         thi cac phuong thuc xu ly nam o phia project cha. (toi uu) 


         */
    }
}

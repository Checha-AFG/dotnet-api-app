using Microsoft.AspNetCore.Mvc;
using System.Linq;
using API_APP.Models;
namespace API_APP.Controllers{
    [Route("api/[controller]")]
    public class ProductosController:Controller{
        private Conexion dbConexion;
        public ProductosController(){
            dbConexion = Conectar.Create();
        }
        //este get devuelve todos los valores
        [HttpGet]
        public ActionResult Get(){
            return Ok(dbConexion.Productos.ToArray());
        }
        //este get devuelve el valor del id en la direccion api/productos/7 (como ejemplo)
        [HttpGet("{id}")]
        public ActionResult GetAction(int id){
            var productos = dbConexion.Productos.SingleOrDefault(a=>a.idproducto==id);
            if (productos != null){
                return Ok(productos);
            }
            else{
                return NotFound();
            }
        }
    }
}
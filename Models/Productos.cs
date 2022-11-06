using System.ComponentModel.DataAnnotations;
namespace API_APP.Models{
    public class Productos{
        [Key]
        public int idproducto{get;set;}
        public string producto{get;set;}
        public int idmarca{get;set;}
        public string descripcion{get;set;}
        public string imagen{get;set;}
        public float precio_costo{get;set;}
        public float precio_venta{get;set;}
        public int existencia{get;set;}
        public string fecha_ingreso{get;set;}
    }
}
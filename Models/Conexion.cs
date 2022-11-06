using Microsoft.EntityFrameworkCore;
namespace API_APP.Models{
    //clase conexion
    class Conexion:DbContext{
        public Conexion(DbContextOptions<Conexion> options):base(options){}
        public DbSet<Productos> Productos {get;set;}
    }

    class Conectar{
        private const string cadenaConexion = "server=localhost;port=3306;database=db_proyectofinal;userid=root;pwd=AaBb12..";
        public static Conexion Create(){
            var constructor = new DbContextOptionsBuilder<Conexion>();
            constructor.UseMySQL(cadenaConexion);
            var cn = new Conexion(constructor.Options);
            return cn;
        }
    }
}
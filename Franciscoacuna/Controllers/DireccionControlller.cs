using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace Franciscoacuna.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DireccionController : ControllerBase
    {
        private string connection = @"Server=localhost; Database=adminestudiantes; Uid=root;";

        [HttpGet]
        public IActionResult get()
        {
            List<Models.Direccion> lst = null;
            using (var db = new MySqlConnection(connection))
            {
                var sql = "SELECT StringDireccion,TipoDireccion,FechaCreacion, FechaActualizacion,EstudianteId,EstadoBorrado from Direccion";
                lst = (List<Models.Direccion>)db.Query<Models.Direccion>(sql);
            }
            return Ok(lst);
        }
    
        [HttpPost]
        public IActionResult insertDireccion(Models.Direccion model)
        {
            int result = 0;
            using (var db= new MySqlConnection(connection))
            {
                var sql = "INSERT into Direccion()"+"values()";
            }

            return Ok(result);
        }

        [HttpPut]
        public IActionResult updateDireccion(Models.Direccion model)
        {
            int result = 0;
            using (var db = new MySqlConnection(connection))
            {
                var sql = "UPDATE Direccion set StringDireccion=@StringDireccion";
                result = db.Execute(sql,model);
            }
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult deleteDirecion(Models.Direccion model)
        {
            int result = 0;
            using (var db = new MySqlConnection(connection))
            {
                var sql = "DELETE from Direccion where id=@id";
                result = db.Execute(sql, model);
            }
            return Ok(result);
        }
    }
}

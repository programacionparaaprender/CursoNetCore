using Microsoft.AspNetCore.Mvc;
//using Models.Models;
//using CursoNetCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBTarjeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
/*         private readonly AutorService _autorService;
        public AutorController(AutorService noticiaService)
        {
            this._autorService = noticiaService;
        }
        [HttpPost]
        [Route("agregar")]
        public IActionResult agregar([FromBody] Autor _autor)
        {
            try
            {
                var resultado = _autorService.agregarAutor(_autor);
                if (resultado)
                    return Ok(resultado);
            }
            catch (Exception ex)
            {

            }
            return BadRequest();
        }

        [HttpPut]
        [Route("editar")]
        public IActionResult editar([FromBody] Autor _autor)
        {
            try
            {
                //_noticia.NoticiaId = id;
                var resultado = _autorService.editarAutor(_autor);
                //return Ok("Prueba de que todo funciona");
                //return HttpResult(200, resultado);
                if (resultado)
                    return Ok(resultado);
            }
            catch (Exception ex)
            {

            }
            return BadRequest();
        }


        [HttpGet]
        [Route("porAutorID/{autorID}")]
        public IActionResult porNoticiaID(int autorID)
        {
            var resultado = _autorService.porAutorID(autorID);
            //return Ok("Prueba de que todo funciona");
            //return HttpResult(200, resultado);
            return Ok(resultado);
        }

        [HttpGet]
        [Route("listadoDeAutores")]
        public IActionResult listadoDeAutores()
        {
            try
            {
                //_noticia.NoticiaId = id;
                var resultado = _autorService.listadoDeAutores();
                //return Ok("Prueba de que todo funciona");
                //return HttpResult(200, resultado);
                return Ok(resultado);
            }
            catch (Exception ex)
            {

            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("eliminar/{autorID}")]
        public IActionResult eliminar(int autorID)
        {
            try
            {
                //_noticia.NoticiaId = id;
                var resultado = _autorService.eliminarAutor(autorID);
                //return Ok("Prueba de que todo funciona");
                //return HttpResult(200, resultado);
                if (resultado)
                    return Ok(resultado);
            }
            catch (Exception ex)
            {

            }
            return BadRequest();
        } */

    }
}

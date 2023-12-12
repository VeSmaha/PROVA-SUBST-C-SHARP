using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Models;
using Api.Db;
namespace Api.Controllers;
[ApiController]
[Route("api/usuario")]
public class UsuarioController:ControllerBase{
    private readonly Context _ctx;
    public UsuarioController(Context ctx){
        _ctx = ctx;
    }

    [HttpGet]
    [Route("listar")]
    public IActionResult Listar(){
        try{
            List<Usuario> usuarios = _ctx.Usuarios.ToList();
            return usuarios.Count==0?NotFound():Ok(usuarios);
            }catch(Exception e){
                return BadRequest(e.Message);
            }
    }

    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Usuario usuario)
    {
        try
        {
            _ctx.Usuarios.Add(usuario);
            _ctx.SaveChanges();
            return Created("",usuario);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
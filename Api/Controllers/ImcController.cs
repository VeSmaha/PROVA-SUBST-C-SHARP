using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Models;
using Api.Db;
namespace Api.Controllers;
[ApiController]
[Route("api/imc")]
public class ImcController : ControllerBase
{
    private readonly Context _ctx;
    public ImcController(Context ctx)
    {
        _ctx = ctx;
    }

    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<Imc> imcs = _ctx.Imcs.Include(objimc=> objimc.Usuario).Include(objimc=> objimc.Usuario).ToList();
            return imcs.Count == 0 ? NotFound() : Ok(imcs);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Imc imc)
    {
        try
        {
            Usuario usuario = _ctx.Usuarios.Find(imc.usuarioId);
            if(usuario==null){
                return NotFound();
            }
            imc.Usuario = usuario;
            _ctx.Imcs.Add(imc);
            _ctx.SaveChanges();
            return Created("", imc);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut]
    [Route("alterar/{ID}")]
    public IActionResult Alterar([FromRoute] int ID,[FromBody] Imc imc)
    {
        try
        {
            Imc? imcobj = _ctx.Imcs.FirstOrDefault(x=>x.ImcID==ID);
            if (imc == null)
            {
                return NotFound();
            }else{
                imcobj.Altura = imc.Altura;
                imcobj.Peso = imc.Peso;
                imcobj.usuarioId = imc.usuarioId;
            }
            _ctx.Imcs.Update(imcobj);
            _ctx.SaveChanges();
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
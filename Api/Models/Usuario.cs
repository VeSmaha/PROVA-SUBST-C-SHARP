using Microsoft.AspNetCore.Mvc;
namespace Api.Models;

public class Usuario{
    public int UsuarioID { get; set; }
    public string Nome { get; set; }

    public string DataNascimento { get; set; }

}
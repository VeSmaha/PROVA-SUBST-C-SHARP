using Microsoft.AspNetCore.Mvc;
namespace Api.Models;

public class Imc
{
    public int ImcID { get; set; }
    public float Altura { get; set; }

    public float Peso { get; set; }

    public int usuarioId { get; set; }

    public Usuario? Usuario  { get; set; }

    public float? ImcTotal { get; set; }

    public string? Classificacao { get; set; }

    public DateTime? CriadoEm { get; set; }

    public Imc(float Altura, float Peso){
        this.Altura = Altura;
        this.Peso = Peso;
        CriadoEm = DateTime.Now;
        ImcTotal = Peso / (Altura * Altura);
        if (ImcTotal < 18.5)
        {
            Classificacao = "Magreza";
        }
        else if (ImcTotal >= 18.5 && ImcTotal <= 24.9)
        {
            Classificacao = "Normal";
        }
        else if (ImcTotal >= 25.0 && ImcTotal <= 29.9)
        {
            Classificacao = "Sobrepeso";
        }
        else if (ImcTotal >= 30.0 && ImcTotal <= 39.9)
        {
            Classificacao = "Obesidade";
        }
        else
        {
            Classificacao = "Obesidade Grave";
        }
    }


}
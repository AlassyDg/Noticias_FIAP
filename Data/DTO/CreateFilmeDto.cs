using System.ComponentModel.DataAnnotations;

namespace Webapiaspnet.Data.DTO;

public class CreateFilmeDto
{


    [Required(ErrorMessage = "O Titulo do Filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O genero é obrigatorio")]
    [StringLength(50, ErrorMessage = "Quantidade de caracteres excedido")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duracao é obrigatoria")]
    [Range(70, 600, ErrorMessage = "Intervalo de tempo invalido,-- minimo 70 e maximo 600")]
    public int Duracao { get; set; }
}

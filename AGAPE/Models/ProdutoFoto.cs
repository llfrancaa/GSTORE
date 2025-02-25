using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AGAPE.Models;

[Table("produto_foto")]
 public class ProdutoFoto
{   
    [Key]
    public int Id {get; set;}

    [Required(ErrorMessage = "por favor, informe o produto")]
    public int ProdutoId { get; set; }
    
    [ForeignKey ("ProdutoId")]
    public Produto Produto{ get; set;}
    
    [Display(Name = "Arquivo")]
    [Required(ErrorMessage = "por favor, informe o arquivo")]
    [StringLength(300)]
    public string ArquivoFoto { get; set; }
    
    [Display(Name = "descrição")]
    [StringLength(100, ErrorMessage = " a descriçao deve possuir no maximo 100 caracteres")]
    public string Descricao { get; set; }

        
}

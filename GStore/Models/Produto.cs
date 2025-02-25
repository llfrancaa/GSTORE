using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    namespace GStore.Models;
    [Table("produto")]
    public class Produto
        {
    [Key]      public int Id  { get; set; }
    [Required(ErrorMessage = "por Favor, infome a categoria")]
    
    public int CategoriaId { get; set; }   
    [ForeignKey("CategoriaId")]
    public Categoria Categoria {get; set; }

    [Required(ErrorMessage = "Por favor, informe o nome")]
    [StringLength(60, ErrorMessage = " o nome deve possuir no maximo 60 caracteres")]
    public string Nome { get; set;}
   
    [Display(Name = "Descrição" , Prompt = " Descrição")]
    [StringLength(1000, ErrorMessage = " a descrição deve possuir no maximo 1000 caracteres")]
    public string Descricao { get; set;}
    
    [Display(Name = "quantidade em estoque")]
    [Required(ErrorMessage = "Por favor, informe  a quantidade em estoque")]
    [Range(0, int.MaxValue)]
    public int QtdeEstoque { get; set; }
    
    [Display(Name = "Valor de custo")]
    [Range(0, double.MaxValue)]
    [Required(ErrorMessage = "Por favor, informe o valor de custo ")]
    [Column(TypeName = "decimal(10,2)")]
    public decimal ValorCusto { get; set; }     

    [Display(Name = "Valor de venda ")]
    [Range(0, double.MaxValue)]
    [Required(ErrorMessage = "Por favor, informe o valor de venda ")]
    [Column(TypeName = "decimal(10,2)")]
    public decimal ValorVenda { get; set; }
    
    public bool Destaque {get; set; } = false;

    public List<ProdutoFoto> Fotos { get; set;}
    }

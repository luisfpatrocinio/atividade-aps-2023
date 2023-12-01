#nullable disable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuisFPatrocinio.Models;

public class Carrinho {
    [Display(Name = "Cod_Car")]
    public int Id {get; set;}
    // public virtual ICollection<Produto> ? Produtos {get; set;}
}

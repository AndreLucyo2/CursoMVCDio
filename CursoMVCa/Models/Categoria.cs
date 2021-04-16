using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CursoMVCa.Models
{
public class Categoria
{
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="O Campo Descrição é obrigatorio.")]
        public string Descricao { get; set; }

        //evitar erro circular
        //public List<Produto> Produtos { get; set; }

    }
}

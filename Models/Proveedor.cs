using System.ComponentModel.DataAnnotations;

namespace MvcProveedores.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string? RFC { get; set; }
        public string? RazonSocial { get; set; }
        public String? DirFiscal { get; set;}
        public string? PermisoCRE { get; set;}
        public string? RegCapital { get; set;}
    }
}

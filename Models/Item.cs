using System.ComponentModel.DataAnnotations;

namespace InventarioApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        [Range(0, 9999)]
        public float Quantitat { get; set; }
        public string TipusQuantitat { get; set; } = string.Empty;
        public float Preu { get; set; }
        public bool Adquirit { get; set; }
    }
}
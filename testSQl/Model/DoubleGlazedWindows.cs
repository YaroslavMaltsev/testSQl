using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSQl.Model
{
  public class DoubleGlazedWindows
    {
        [Key]
        public int Id { get; set; }
        public string? ArticleSP { get; set; }
        public int Chamberness { get; set; }
        public int ThicknessSP { get; set; }
        public int GlassThickness { get; set; }
    }
}

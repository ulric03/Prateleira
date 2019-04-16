using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectDependentionGetServiceByCtor
{
    public interface ITimes
    {
        string Time { get; set; }
    }

    public class Corinthians : ITimes
    {
        public string Time { get; set; } = "Corinthians";
    }

    public class SaoBento : ITimes
    {
        public string Time { get; set; } = "SaoBento";
    }
}

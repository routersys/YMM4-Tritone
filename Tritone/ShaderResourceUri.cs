using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tritone
{
    internal class ShaderResourceUri
    {
        public static Uri Get(string shaderName) => new Uri($"pack://application:,,,/Tritone;component/Shaders/{shaderName}.cso", UriKind.Absolute);
    }
}

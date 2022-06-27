using PortalControleTI.Data;
using PortalControleTI.Model;
using System.Collections.Generic;
using System.Linq;

namespace PortalControleTI.Core
{
    public class ComputadorCore
    {
        public static void Add(Computador computador)
        {
            ComputadorData.Incluir(computador);
        }

        public static IEnumerable<Computador> Get()
        {
            return ComputadorData.GetComputadores().OrderBy(p => p.DataAtualizacao);
        }

        public static Computador Get(string serial)
        {
            return ComputadorData.GetComputadores().FirstOrDefault(p => p.Serial == serial);
        }

        public static void Update(Computador computador)
        {
            ComputadorData.Atualizar(computador);
        }
    }
}

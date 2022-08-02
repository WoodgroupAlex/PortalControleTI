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

        public static Computador Get(int Id)
        {
            return ComputadorData.GetComputadores().FirstOrDefault(p => p.Id == Id);
        }

        public static void Update(Computador computador)
        {
            ComputadorData.Atualizar(computador);
        }
    }
}

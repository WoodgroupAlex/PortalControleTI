using PortalControleTI.Model;
using System.Collections.Generic;

namespace PortalControleTI.Services
{
    public interface IComputadorData
    {
        IEnumerable<Computador> Get();
        Computador Get(int Id);
        void Add(Computador cliente);
        void Update(Computador cliente);
        void Delete(int Id);
    }
}

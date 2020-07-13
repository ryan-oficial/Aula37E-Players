using System.Collections.Generic;

namespace Aula37E_Players.Models
{
    public interface IEquipe
    {
         void Create(Equipe e);
         List<Equipe> ReadAll();
         void Update(Equipe e);
         void Delete(int id);
    }
}
using Domain;

namespace Infraestructure
{
    public class TeamRepositoryInMemory : ITeamRepository
    {
        public IList<Team> Search(string termoDePesquisa)
        {
            ///2 - REALIZAR PESQUISA NA COLEÇÃO EM MEMÓRIA E RETORNAR RESULTADO
            return new List<Team>();
        }

        public void Add(Team entidade)
        {
            ///3 - ADICIONAR A ENTIDADE (DO SEU TEMA) NA COLEÇÃO EM MEMÓRIA
        }
        
    }
}
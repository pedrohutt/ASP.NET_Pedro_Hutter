using TeamManager.ViewModels;
namespace TeamManager.Repositories​
{ 
    public static class TeamsRepository
    {
        private static List<TeamViewModel> timesList = new List<TeamViewModel>();

        public static List<TeamViewModel> GetAll()
        {
            return timesList;
        }

        public static TeamViewModel GetById(Guid id)
        {
        TeamViewModel? retorno = null;

            if (id != Guid.Empty)
            {
                retorno = timesList.FirstOrDefault(p => p.Id == id);
            }

            if (retorno == null) retorno = new TeamViewModel();

            return retorno;
        }

        public static List<TeamViewModel> GetBySearch(string searchString)
        {
            List<TeamViewModel>? retorno = null;

            if (!String.IsNullOrEmpty(searchString))
            {
                retorno = timesList.Where(p => p.Name.Contains(searchString)).ToList();
            }

            if (retorno == null) retorno = new List<TeamViewModel>();

            return retorno;
        }

        public static void Create(TeamViewModel aluno)
        {
            timesList.Add(aluno);
        }

        public static void Update(TeamViewModel time)
        {
            TeamViewModel? retorno = null;

            if (time.Id != Guid.Empty)
            {
                retorno = timesList.FirstOrDefault(p => p.Id == time.Id);

                if (retorno != null)
                {
                    retorno.Name = time.Name;
                    retorno.Estado = time.Estado;
                    retorno.DataCriacao = time.DataCriacao;
                    retorno.TitulosBrasileiros = time.TitulosBrasileiros;
                    retorno.TitulosEstaduais = time.TitulosEstaduais;
                }
            }
        }

        public static void Delete(Guid id)
        {
            TeamViewModel? retorno = null;

            if (id != Guid.Empty) retorno = timesList.FirstOrDefault(p => p.Id == id);
            if (retorno != null) timesList.Remove(retorno);
        }
    }
}

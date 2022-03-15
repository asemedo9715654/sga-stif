namespace sga_stif.Models
{
    public static class InicializacaoBaseDados
    {
        public static void Initialize(ContextoBaseDados context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Utilizador.Any())
            {
                return;   // DB has been seeded
            }




            var utilizaddors = new Utilizador[]
            {
                new Utilizador{
                    Nome="Angelo",
                    Apelido="Semedos",
                    Eliminado = false,
                    Foto="jjj",
                    PalavraPasse ="jjj",
                    PalavraPasseSalt = "ddd",
                    DataCriacao=DateTime.Now,
                    DataAtualizacao=DateTime.Now
                    
                    },
           
            };
            foreach (Utilizador s in utilizaddors)
            {
                context.Utilizador.Add(s);
            }
            context.SaveChanges();
        }
    }
}
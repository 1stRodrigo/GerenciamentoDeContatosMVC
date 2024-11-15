namespace GerenciamentoDeContatosMVC.Models
{
    public class ContactRepository
    {
        private static List<Contato> contatos = new List<Contato>();
        private static int nextId = 1;

        public List<Contato> GetAllContatos()
        {
            return contatos;
        }

        public void AddContato(Contato contato)
        {
            contato.Id = nextId++;
            contatos.Add(contato);
        }

        public void RemoveContato(int id)
        {
            var contato = contatos.FirstOrDefault(c => c.Id == id);
            if (contato != null)
            {
                contatos.Remove(contato);
            }
        }
    }
}

namespace TesteInsereAutoConclusao.Models
{
    public class AutoConcluHabita: Entity
    {
        public string ProtocoloN { get; set; }
        public string AutoConclu { get; set; }
        public string ProjetoN { get; set; }
        public string Requerente { get; set; }
        public string Quadra { get; set; }
        public int Lote { get; set; }   
        public string Endereco { get; set; }
        public string DataLicenca { get; set; }   
        public string ConclusaoObra { get; set; }

    }
}

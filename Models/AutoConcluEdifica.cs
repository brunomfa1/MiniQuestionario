namespace TesteInsereAutoConclusao.Models
{
    public class AutoConcluEdifica : Entity
    {
        public string ProtocoloN { get; set; }    
        public string TipoUnidade { get; set; }
        public string Material { get; set; } 
        public string RevestimentoExterno { get; set; }
        public string RevestimentoInterno { get; set; }
        public string Esquadria { get; set; }
        public string Estrutura { get; set; }
        public string Cobertura { get; set; }
        public string InstalacaoSanitaria { get; set; }
        public string Forro { get; set; }
        public string InstalacaoEletrica { get; set; }
        public string Piso { get; set; }
        public string Limitacao { get; set; }
    }
}

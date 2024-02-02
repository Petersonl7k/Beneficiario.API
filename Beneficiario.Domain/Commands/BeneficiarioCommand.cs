namespace Beneficiario.Domain.Commands
{
    public class BeneficiarioCommand
    {
        public int beneficiarioID { get; set; }
        public string nomeBeneficiario { get; set; }
        public string estadoBeneficiario { get; set; }
        public int idadeBeneficiario { get; set; }
        public string beneficiarioCEP { get; set; }
        public string bairroBeneficiario { get; set; }
        public long telefoneBeneficiario { get; set; }
        public string emailBeneficiario { get; set; }
        public bool ativoBeneficiario { get; set; }
    }
}

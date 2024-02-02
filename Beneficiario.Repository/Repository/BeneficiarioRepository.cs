using Beneficiario.Domain.Commands;
using Beneficiario.Domain.Interface;
using Dapper;
using System.Data.SqlClient;

namespace Beneficiario.Repository.Repository
{
    public class BeneficiarioRepository : IBeneficiarioRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<IEnumerable<BeneficiarioCommand>> GetAsync()
        {
            string querygetBeneficiario = @"Select * From CadastroBeneficiario where ativoBeneficiario = 1";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                return await conn.QueryAsync<BeneficiarioCommand>(querygetBeneficiario);

            }
        }
        public async Task<string> PostAsync(BeneficiarioCommand command)
        {
            string queryinsert = @"Insert Into CadastroBeneficiario(nomeBeneficiario, estadoBeneficiario, idadeBeneficiario, beneficiarioCEP, bairroBeneficiario, telefoneBeneficiario, emailBeneficiario)
            Values (@nomeBeneficiario, @estadoBeneficiario, @idadeBeneficiario, @beneficiarioCEP, @bairroBeneficiario, @telefoneBeneficiario, @emailBeneficiario)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryinsert, new
                {
                    nomeBeneficiario = command.nomeBeneficiario,
                    estadoBeneficiario = command.estadoBeneficiario,
                    idadeBeneficiario = command.idadeBeneficiario,
                    beneficiarioCEP = command.beneficiarioCEP,
                    bairroBeneficiario = command.bairroBeneficiario,
                    telefoneBeneficiario = command.telefoneBeneficiario,
                    emailBeneficiario = command.emailBeneficiario,
                });
                return "Beneficiario cadastrado com sucesso";
            }
        }
        public async Task<string> UpdateAsync(BeneficiarioCommand command)
        {
            string queryupdate = @"Update CadastroBeneficiario set nomeBeneficiario=@nomeBeneficiario, estadoBeneficiario=@estadoBeneficiario, idadeBeneficiario=@idadeBeneficiario,
            beneficiarioCEP=@beneficiarioCEP, bairroBeneficiario=@bairroBeneficiario, telefoneBeneficiario=@telefoneBeneficiario, emailBeneficiario=@emailBeneficiario where emailBeneficiario = @emailBeneficiario";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryupdate, new
                {
                    nomeBeneficiario = command.nomeBeneficiario,
                    estadoBeneficiario = command.estadoBeneficiario,
                    idadeBeneficiario = command.idadeBeneficiario,
                    beneficiarioCEP = command.beneficiarioCEP,
                    bairroBeneficiario = command.bairroBeneficiario,
                    telefoneBeneficiario = command.telefoneBeneficiario,
                    emailBeneficiario = command.emailBeneficiario,
                });
                return "Update realiado com sucesso";
            }
        }
        public async Task<string> DeleteAsync(string email)
        {
            string querydelete = @"Update CadastroBeneficiario set ativoBeneficiario=@ativoBeneficiario where emailBeneficiario = @email";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(querydelete, new
                {
                    ativoBeneficiario = 0,
                    email = email
                });
                return "Beneficiario desativado com sucesso";
            }
        }



    }
}


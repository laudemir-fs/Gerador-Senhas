namespace GeradorSenhas.Interfaces;

public interface IPasswordService
{
    string GerarHashSenha(string senha);
    bool VerificarSenha(string senhaDigitada, string senhaHashArmazenada);
}
using GeradorSenhas.Models;

namespace GeradorSenhas.Interfaces;

public interface IJwtService
{
    string GenerateJwtToken(Usuario user);
}
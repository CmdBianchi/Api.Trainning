using System;
using X.Game.Domain.Arguments.Jogador;
using X.Game.Domain.Enum;
using X.Game.Domain.ValueObjects;

namespace X.Game.Domain.Interfaces.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request);
    }
}

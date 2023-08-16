using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_API_complete_
{
    public interface IPokemonLogic
    {
        Task<Pokemon> pokemonLogic(Pokemon pokeObject);
    }
}

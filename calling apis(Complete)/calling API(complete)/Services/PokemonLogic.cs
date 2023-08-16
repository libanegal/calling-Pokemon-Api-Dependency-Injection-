using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_API_complete_
{
    public class PokemonLogic:IPokemonLogic
    {
        public async Task<Pokemon> pokemonLogic(Pokemon pokeObject)
        {
            List<PokemonSpecy> pokemons = new List<PokemonSpecy>();

            foreach (var poke in pokeObject.pokemon_species)
            {
                pokemons.Add(poke);
            }
            return pokeObject;
        }
    }
}

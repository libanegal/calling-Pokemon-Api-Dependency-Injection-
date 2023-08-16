using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_API_complete_
{
    public  class PokemonOrchestrator
    {
        private readonly IAddPokemons _AddPokemons;
        private readonly IPokemonCall _PokemonCall;
        private readonly IPokemonLogic _PokemonLogic;
        public PokemonOrchestrator(IAddPokemons addPokemons, IPokemonCall pokemonCall, IPokemonLogic pokemonLogic) 
        {
             _AddPokemons = addPokemons;
             _PokemonCall = pokemonCall;
             _PokemonLogic = pokemonLogic;
        }

        public async Task<Pokemon> PokemonOrch() 
        {
            var pokeObject = await _PokemonCall.GetTaskAsync();
            var addpokemons = await _AddPokemons.Addpokemons(pokeObject);
            var pokemonlogic = await _PokemonLogic.pokemonLogic(pokeObject);
            return pokeObject;
        }
    }
}

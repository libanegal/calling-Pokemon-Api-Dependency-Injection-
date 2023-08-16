using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_API_complete_
{
    public  class AddPokemons:IAddPokemons
    {
        public async Task<Pokemon> Addpokemons(Pokemon pokeObject) 
        {
            var pokemon = new PokemonSpecy()
            {
                name = "Liban",
                url = "www.google.com",

            };
            var pokemon1 = new PokemonSpecy()
            {
                name = "Egal",
                url = "www.Facebook.com",

            };

            var pokeSpecies = pokeObject.pokemon_species;
            pokeSpecies.Add(pokemon);
            pokeSpecies.Add(pokemon1);
            return pokeObject;
           
        }
    }
}

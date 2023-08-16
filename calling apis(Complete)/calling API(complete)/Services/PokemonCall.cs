using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace calling_API_complete_
{
    public class PokemonCall:IPokemonCall
    {
        public async Task<Pokemon> GetTaskAsync() 
        {
            var _httpClient = new HttpClient();
            var requestMessage = new HttpRequestMessage();
            requestMessage.RequestUri = new Uri("https://pokeapi.co/api/v2/pokemon-color/1/");
            var request = await _httpClient.SendAsync(requestMessage);
            var response = await request.Content.ReadAsStringAsync();
            var pokeObject = JsonConvert.DeserializeObject<Pokemon>(response);            
            return pokeObject;
        }
    }
}

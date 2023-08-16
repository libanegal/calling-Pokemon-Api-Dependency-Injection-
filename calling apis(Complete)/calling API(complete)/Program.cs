using calling_API_complete_;
using Microsoft.Extensions.DependencyInjection;

var service = new ServiceCollection();

service.AddSingleton<IPokemonCall,PokemonCall>();
service.AddScoped<IPokemonLogic,PokemonLogic>();
service.AddTransient<IAddPokemons, AddPokemons>();


var serviceProvider = service.BuildServiceProvider();

var pokemonCall = serviceProvider.GetRequiredService<IPokemonCall>();

var pokemonLogic = serviceProvider.GetRequiredService<IPokemonLogic>();

var addpokemons = serviceProvider.GetRequiredService<IAddPokemons>();

var pokeOrch = new PokemonOrchestrator(addpokemons, pokemonCall, pokemonLogic);

var orchestrate = await pokeOrch.PokemonOrch();

Console.WriteLine(orchestrate);

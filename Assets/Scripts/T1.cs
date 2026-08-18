using UnityEngine;

public class T1 : MonoBehaviour
{
    void Start()
    {
        Pokemon Charmander = new Pokemon();
        Charmander.PokeNombre = "Charmander";
        Charmander.Ataque = 6;
        Charmander.Vitalidad = 7;
        Charmander.Tipo = TiposPokemon.Fuego;

        Pokemon Bulbasaur = new Pokemon();
        Bulbasaur.PokeNombre = "Bulbasaur";
        Bulbasaur.Ataque = 7;
        Bulbasaur.Vitalidad = 5;
        Bulbasaur.Tipo = TiposPokemon.Planta;

        Pokemon Squirtle = new Pokemon();
        Squirtle.PokeNombre = "Squirtle";
        Squirtle.Ataque = 8;
        Squirtle.Vitalidad = 6;
        Squirtle.Tipo = TiposPokemon.Agua;

        Charmander.Introduccion();
        Bulbasaur.Introduccion();
        Squirtle.Introduccion();


    }
}

    public enum TiposPokemon
    {
        Planta, // ->0
        Fuego,  // ->1
        Agua // ->2
    }

    public class Pokemon
    {
        // Atributos
        public string PokeNombre;
        public int Ataque;
        public int Vitalidad;
        public TiposPokemon Tipo;
       
        //Metodos o comportamiento ->
        public void Introduccion()
        {
            Debug.Log("Soy" + PokeNombre
                + "\n Mis puntos de ataque son:" + Ataque
                + "\n Mis puntos de defensa son:" + Vitalidad
                + "\n Soy de tipo: " + Tipo.ToString());
        }


    }


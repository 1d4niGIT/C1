using UnityEngine;
using static T1;

public class lab : MonoBehaviour
{
    
    void Start()
    {
        Player reptile = new Player();
        reptile.Name = "Reptile";
        reptile.atk = 10;
        reptile.vida = 100;
        reptile.veloc = 150;
        reptile.Type = Razas.reptil;

        reptile.introduction();
    }
    public enum Razas
    {
        orco,
        reptil,
        minotauro,
        soul

    }
    public class Player
    {
        public string Name;
        public int atk;
        public int vida;
        public int veloc;
        public Razas Type;


        public void introduction()
        {
            Debug.Log("soy" + Name
                + "\n Mis puntos de ataque son: " + atk
                + "\n Mis puntos de defensa son: " + vida
                + "\n Soy un : " + Type.ToString());
        }


    }

}
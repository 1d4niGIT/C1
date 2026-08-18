using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int HP = 100;

        
       
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Morir(int Daño)
    {
        HP -= Daño;
    
       if ( HP  < 0 ) 
        {
            Destroy(gameObject);
            print("muerete bastardo");
        }
    }
}

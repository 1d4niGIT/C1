using UnityEngine;

public class Coin : MonoBehaviour
{
    
    void Start()
    {
        Moneda Moneda = new Moneda();
        Moneda Moneda1 = new Moneda();
        Moneda Moneda2 = new Moneda();
        Moneda Moneda3 = new Moneda();
        Moneda Moneda5 = new Moneda();

    }

    public void OnTriggerEnter2D(Collider2D Colisionador)
    {
        Moneda ComponenteMoneda = GetComponent<Moneda>();
        if (Colisionador.CompareTag("Player"))
        {
            ComponenteMoneda.ComportamientoMoneda();
            Destroy(gameObject);
        }
    }
}
public class Moneda
{
    public int Valor = 10;
    public int MonedasColeccionadas = 0;
    public void ComportamientoMoneda()
    {
        MonedasColeccionadas += Valor;
        
        Debug.Log($"Monedas actuales son:{MonedasColeccionadas}");
    }
}
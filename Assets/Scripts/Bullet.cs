using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Existe = 3;
    public float Speed = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy (gameObject, Existe);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * Speed * Time.deltaTime;
    }
}

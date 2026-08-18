using UnityEngine;

public class Mov : MonoBehaviour
{
    public float HorizontalMovement;
    public float VerticalMovement;
    public float veloc;
    public float vida;
    public Vector2 direccionMirando = Vector2.down;

    public bool moving;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }
    public void MovementPlayer()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");



        Vector3 dir = new Vector3(x, y, 0);
        dir.Normalize();
        if (dir.magnitude > 0.1f)
        {
            direccionMirando = new Vector2(x, y).normalized;
        }
        float i = transform.position.y;
        float e = transform.position.x;

        transform.position += dir * veloc * Time.deltaTime;

       
    }
}
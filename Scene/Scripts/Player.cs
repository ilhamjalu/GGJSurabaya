using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D body;
    public GameObject player;
    private int speed = 15;
    private int jump = 500;
    private bool ground = false;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("nyentuh");
        ground = true;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left * speed * Time.deltaTime;

        }
        if (ground == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("lompat");
                body.AddForce(Vector2.up * jump);
                ground = false;
            }
        }
       
    }



}

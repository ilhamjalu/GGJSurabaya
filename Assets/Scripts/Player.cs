using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D body;
    public GameObject player;
    public int speed = 15;
    public int jump = 500;
    private bool ground = false;

    public Animator animator;
    public GameManager gameManager;

    bool isDone = false;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("nyentuh");
        ground = true;

        if(collision.gameObject.tag == "Gate")
        {
            gameManager.playerCount += 1;
            isDone = true;
        }
    }
    private void Update()
    {
        if (!isDone)
        {
            if (Input.GetKey(KeyCode.D))
            {
                player.transform.position += Vector3.right * speed * Time.deltaTime;
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                animator.SetBool("isWalk", true);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                player.transform.position += Vector3.left * speed * Time.deltaTime;
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                animator.SetBool("isWalk", true);
            }
            else
            {
                animator.SetBool("isWalk", false);
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
}

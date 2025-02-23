using UnityEngine;

public class BirdController : MonoBehaviour
{

    public float velocity =2f;
    public Rigidbody2D rb;
    public bool isDeath;
    public GameManager managerGame;

    public GameObject DeathScreen;

   private void Start()
    {
        Time.timeScale = 1 ;
    }
    void Update()
    {
        //mouse sol tık kısmını al
       if(Input.GetMouseButtonDown(0))
       {
        //havada kuş uçabilsim
        rb.linearVelocity =Vector2.up * velocity;
       } 
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.name=="ScoreArea")
      {
            managerGame.UpdateScore();
      }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="DeathArea")
        {
            isDeath = true;
            Time.timeScale = 0 ;
            DeathScreen.SetActive(true);
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float JumpForce;
    float score;

    [SerializeField]
    bool isGrounded = false;
    bool isAlive = true;

    Rigidbody2D RB;

    public Text scoreText;
    public GameOverScreen GameOverScreen;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            RB.AddForce(Vector2.up * JumpForce);
            isGrounded = false;
        }

        if (isAlive)
        {
            score += Time.deltaTime * 100;
            scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("spike"))
        {
            isAlive = false;
            Time.timeScale = 0;
            GameOver(); 
        }
    }

    void GameOver()
    {
        GameOverScreen.Setup(); 
    }
}

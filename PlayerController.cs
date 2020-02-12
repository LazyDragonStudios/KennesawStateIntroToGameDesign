using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using unityEngine.SceneManagement;

//jade ainsworth
public class PlayerController : MonoBehaviour
{

    public float speed,x,y,z;
    public Text countText;
    public Text ending;
   

    
    private Rigidbody rb;
    private int count;

   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
       

    }

    void FixedUpdate()
    {
        float a=0;
        float b=0;
        if (Input.GetAxis("Horizontal") || Input.GetAxis("Vertical"))
        {
            if (this.gmaeObject.tag.equals("Player") || this.gameObject.tag.Equals("Player1"))
            {
                // float moveHorizontal = Input.GetAxis("Horizontal");
                //  float moveVertical = Input.GetAxis("Vertical");
                if (Input.GetKey(KeyCode.W))
                {
                    b = 1;
                }
                if (Input.GetKey(KeyCode.S))

                {
                    b = -1;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    a = -1;
                }
                if (Input.GetKey(KeyCode.D))
                {
                    a = 1;
                }


            }
            else if (this.gameObject.tag.Equals("Player2"))
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    b = 1;
                }
                if (Input.GetKey(KeyCode.DownArrow))

                {
                    b = -1;
                }

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    a = -1;
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    a = 1;
                }
            }
            Vector3 movement = new Vector3(a, 0.0f, b);

            rb.AddForce(movement * speed);
        }

    }
    void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (this.gameObject.tag.Equals("Player"))
        {
            //respawn
            if (other.gameObject.tag.Equals("PlayArea"))
            {
                this.GetComponent<Transform>().position = new Vector3(x, y, z);
            }

            //death
            if (other.gameObject.tag.Equals("Enemy"))
            {
                this.gameObject.SetActive(false);
                ending.text = "you died!";
                Invoke("GameOver", 2.0f);
            }

            //win
            if (other.gameObject.tag.Equals("FinishLine"))
            {
                ending.text = "you won!";
                Invoke("GameOver", 2.0f);
            }


        }

        if (this.gameObject.tag.Equals("Player1"))
        {
            //respawn
            if (other.gameObject.tag.Equals("PlayArea"))
            {
                this.GetComponent<Transform>().position = new Vector3(x, y, z);
            }

            //death
            if (other.gameObject.tag.Equals("Enemy"))
            {
                this.gameObject.SetActive(false);
                ending.text = "Player 1 died, player 2 wins!";
                Invoke("GameOver", 2.0f);
            }

            //win
            if (other.gameObject.tag.Equals("FinishLine"))
            {
                ending.text = "player 1 reached the finish line, player 1 wins!";
                Invoke("GameOver", 2.0f);
            }
        }

        if (this.gameObject.tag.Equals("Player2"))
        {
            //respawn
            if (other.gameObject.tag.Equals("PlayArea"))
            {
                this.GetComponent<Transform>().position = new Vector3(x, y, z);
            }

            //death
            if (other.gameObject.tag.Equals("Enemy"))
            {
                this.gameObject.SetActive(false);
                ending.text = "Player 2 died, player 1 wins!";
                Invoke("GameOver", 2.0f);
            }

            //win
            if (other.gameObject.tag.Equals("FinishLine"))
            {
                ending.text = "player 2 reached the finish line, player 2 wins!";
                Invoke("GameOver", 2.0f);
            }

        }

    }

}
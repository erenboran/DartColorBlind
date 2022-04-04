using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject yanlis;
    public Rigidbody2D yanlis2;
    private Vector3 kontrol  = new Vector3(0f, -3.51f, 0f);



    void Start()
    {
       // yanlis.GetComponent<Rigidbody2D>();
        GetComponent<ColorRandomizer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D (Collider2D other)
    {
        
          
            if(gameObject.tag == "restart")
            {
                SceneManager.LoadScene("SampleScene");

            Destroy(gameObject);
        }
            else if(gameObject.tag == "NextLevel")
        {
            //SceneManager.LoadScene("1");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

        else if (gameObject.tag == "Log")
        {
           
           
            yanlis2.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            if (yanlis.transform.position == kontrol)
            {
                yanlis2.constraints = RigidbodyConstraints2D.FreezePositionY;
            }
        }


    }
}


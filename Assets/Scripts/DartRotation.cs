using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartRotation : MonoBehaviour
{

    public float degreesPerSecond = 20;
    public GameObject arrow;
    public Transform ArrowFirstLoc;
    public Rigidbody2D rb;

    private void Awake()
    {
       // rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            rb.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (gameObject.tag == "Log")
        {
            // rb.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            rb.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

            arrow.transform.position = ArrowFirstLoc.transform.position;
            StartCoroutine(Test());
            Debug.Log("sadas");

            //if (Input.GetMouseButton(0))
            //{
            //    rb.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            //}


        }
        if (gameObject.tag == "Knife")
        {
            // rb.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Debug.Log("tgest");

        }
        IEnumerator Test()
        {

            yield return new WaitForSeconds(232);
        }
    }

}

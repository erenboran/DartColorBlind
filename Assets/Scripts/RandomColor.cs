using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public Color color;
    void Start()
    {
        GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        color = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));

    }
}

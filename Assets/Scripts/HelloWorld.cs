using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public GameObject helloText;
    public int speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        print("bye world"); //sa
        helloText.GetComponent<TextMeshPro>().text = "shrek production sunar...";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed);
    }
}
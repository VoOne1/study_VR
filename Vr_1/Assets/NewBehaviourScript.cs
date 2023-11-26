using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int c = 10;
    public float speed = 10f;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * 5 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.down * 5 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * 5 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up * 5 * speed * Time.deltaTime);
        }
        if (c <= 0)
        {
            gameObject.SetActive(false);
            t.text = "Game Over!";
        }
        else
        {
            t.text = c.ToString();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        c--;
    }
    private void OnCollisionExit(Collision collision)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}

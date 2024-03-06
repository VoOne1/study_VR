using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

/* 3 .Создать базовую сцену, которая будет содержать в себе 2 3D-объекта и 1 поле,
 * а также элементы пользовательского интерфейса типа кнопки и текста. Все элементы
 * должны быть видны на камере; 5. Создать скрипт, деактивирующий определённый объект
 * на сцене по нажатию кнопки в случае его активного состояния и активации при неактивном.
 */

public class ForCube : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public GameObject cylinder;
    public Text x;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     
    }
    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }
    private void OnMouseUp()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnMouseEnter()
    {
        cylinder.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnMouseExit()
    {
        cylinder.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

    public void heal()
    {
        if (this.gameObject.activeSelf==false)
        {
            this.gameObject.SetActive(true);
            x.text = "Cube is active";
        }
        else if (this.gameObject.activeSelf == true)
        {
            this.gameObject.SetActive(false);
            x.text = "Cube is not active";
        }
    }
}

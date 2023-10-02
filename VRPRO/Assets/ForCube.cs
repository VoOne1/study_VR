using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

/* 3 .������� ������� �����, ������� ����� ��������� � ���� 2 3D-������� � 1 ����,
 * � ����� �������� ����������������� ���������� ���� ������ � ������. ��� ��������
 * ������ ���� ����� �� ������; 5. ������� ������, �������������� ����������� ������
 * �� ����� �� ������� ������ � ������ ��� ��������� ��������� � ��������� ��� ����������.
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

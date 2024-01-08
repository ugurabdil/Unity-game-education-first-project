using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContreller : MonoBehaviour
{
    private Rigidbody2D rgb2;
    public int speed;

    private int totalgold;
    public Text totalgoldtext;

    public void Start()
    {
        rgb2=GetComponent<Rigidbody2D>();

    }

    public void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement=new Vector2(moveHorizontal, moveVertical);
        rgb2.AddForce(movement*speed);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gold"))
        {
            collision.gameObject.SetActive(false);
            totalgold++;
            Debug.Log(totalgold);
            totalgoldtext.text = "Total Gold "+totalgold.ToString();
        }
    }
}

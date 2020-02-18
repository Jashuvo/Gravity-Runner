using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    private float width = 0f;
    
    void Awake()
    {
        width = GameObject.Find("BG").GetComponent<BoxCollider2D>().size.x;

    }

    
    void OnTriggerEnter2D(Collider2D collider){
        if (collider.tag == "BG" || collider.tag == "Floor")
        {
            Vector3 temp =  collider.transform.position;
            temp.x += width * 3;
            collider.transform.position = temp;
        }
        if (collider.tag == "Coin" || collider.tag == "Rocket"){
            collider.gameObject.SetActive(false);
        }
    }
}

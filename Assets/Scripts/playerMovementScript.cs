using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovementScript : MonoBehaviour
{
    private Button jumpButton;
    private Rigidbody2D playerRigid;

    private float speed = 3f;

    void Awake(){
        jumpButton = GameObject.Find("Jump").GetComponent<Button>();
        playerRigid = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
        
    }

    public void Jump(){
        playerRigid.gravityScale *= -1;
        Vector3 temp = transform.localScale;
        temp.y *= -1;
        transform.localScale = temp;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerScoreScript : MonoBehaviour
{
    private int score = 0;

    [SerializeField]
    TextMeshProUGUI gameScoreText,bestScoreText;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider){
        if (collider.tag == "Coin"){
            score++;
            gameScoreText.text = score.ToString();
            collider.gameObject.SetActive(false);
        }

        if (collider.tag == "Rocket"){
            transform.position = new Vector3(0,1000,0);
            collider.gameObject.SetActive(false);
        }
    }
}

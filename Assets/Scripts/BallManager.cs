using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ボールが何かに衝突したら
    void OnCollisionEnter2D (Collision2D coll)
    {
        // 「outArea」に衝突したら
        if (coll.gameObject.tag == "OutArea"){

            // GameManagerを取得
            GameObject gameManager = GameObject.Find("GameManager");

            // リトライ
            gameManager.GetComponent<GameManager>().PushRetryButton();
        }
    }
}

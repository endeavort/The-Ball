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

    // �{�[���������ɏՓ˂�����
    void OnCollisionEnter2D (Collision2D coll)
    {
        // �uoutArea�v�ɏՓ˂�����
        if (coll.gameObject.tag == "OutArea"){

            // GameManager���擾
            GameObject gameManager = GameObject.Find("GameManager");

            // ���g���C
            gameManager.GetComponent<GameManager>().PushRetryButton();
        }
    }
}

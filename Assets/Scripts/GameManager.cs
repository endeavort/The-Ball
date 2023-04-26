using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int StageNo; // �X�e�[�W�i���o�[

    public bool isBallMoving; // �{�[���ړ����t���O

    public GameObject ballPrefab; // �{�[���v���n�u
    public GameObject ball; // �{�[���I�u�W�F�N�g

    public GameObject goButton; // �{�^���F�Q�[���J�n
    public GameObject retryButton; // �{�^���F���g���C

    // Start is called before the first frame update
    void Start()
    {
        retryButton.SetActive(false); // RETRY�{�^����\��
        isBallMoving = false; // �{�[���ړ����t���O�ufalse�v
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // GO�{�^��
    public void PushGoButton()
    {
        // �{�[���̏d�͂�L����
        Rigidbody2D rd = ball.GetComponent<Rigidbody2D>();
        rd.isKinematic = false;

        retryButton.SetActive(true); // RETRY�{�^���\��
        goButton.SetActive(false); // GO�{�^����\��
        isBallMoving = true; // �{�[���ړ����t���O�utrue�v
    }

    // RETRY�{�^��
    public void PushRetryButton()
    {
        Destroy(ball); // �{�[���I�u�W�F�N�g�̔j��

        // �u���n�u���V�����{�[���I�u�W�F�N�g���쐬
        ball = (GameObject)Instantiate(ballPrefab);

        retryButton.SetActive(false); // ���g���C�{�^����\��
        goButton.SetActive(true); // GO�{�^���\��
        isBallMoving = false; // �{�[���ړ����t���O�ufalse�v
    }
}
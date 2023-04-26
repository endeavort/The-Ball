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
    public GameObject clearText; // �e�L�X�g�F�N���A

    public AudioClip clearSE; // ���ʉ��F�N���A
    private AudioSource audioSource; // �I�[�f�B�I�\�[�X

    // Start is called before the first frame update
    void Start()
    {
        retryButton.SetActive(false); // RETRY�{�^����\��
        isBallMoving = false; // �{�[���ړ����t���O�ufalse�v

        // �I�[�f�B�I�\�[�X���擾
        audioSource = gameObject.GetComponent<AudioSource>();
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

    // �X�e�[�W�N���A����
    public void StageClear()
    {
        audioSource.PlayOneShot(clearSE); // �N���A���Đ�
        clearText.SetActive(true); // �N���A�\��
        retryButton.SetActive(false); // ���g���C�{�^����\��
    }

    // BACK�{�^��
    public void PushBackButton()
    {
        GobackStageSelect();
    }

    // �V�[���ړ�����
    void GobackStageSelect()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
}

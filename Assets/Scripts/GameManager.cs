using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int StageNo; // ステージナンバー

    public bool isBallMoving; // ボール移動中フラグ

    public GameObject ballPrefab; // ボールプレハブ
    public GameObject ball; // ボールオブジェクト

    public GameObject goButton; // ボタン：ゲーム開始
    public GameObject retryButton; // ボタン：リトライ
    public GameObject clearText; // テキスト：クリア

    public AudioClip clearSE; // 効果音：クリア
    private AudioSource audioSource; // オーディオソース

    // Start is called before the first frame update
    void Start()
    {
        retryButton.SetActive(false); // RETRYボタン非表示
        isBallMoving = false; // ボール移動中フラグ「false」

        // オーディオソースを取得
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // GOボタン
    public void PushGoButton()
    {
        // ボールの重力を有効化
        Rigidbody2D rd = ball.GetComponent<Rigidbody2D>();
        rd.isKinematic = false;

        retryButton.SetActive(true); // RETRYボタン表示
        goButton.SetActive(false); // GOボタン非表示
        isBallMoving = true; // ボール移動中フラグ「true」
    }

    // RETRYボタン
    public void PushRetryButton()
    {
        Destroy(ball); // ボールオブジェクトの破壊

        // ブレハブより新しいボールオブジェクトを作成
        ball = (GameObject)Instantiate(ballPrefab);

        retryButton.SetActive(false); // リトライボタン非表示
        goButton.SetActive(true); // GOボタン表示
        isBallMoving = false; // ボール移動中フラグ「false」
    }

    // ステージクリア処理
    public void StageClear()
    {
        audioSource.PlayOneShot(clearSE); // クリア音再生
        clearText.SetActive(true); // クリア表示
        retryButton.SetActive(false); // リトライボタン非表示
    }

    // BACKボタン
    public void PushBackButton()
    {
        GobackStageSelect();
    }

    // シーン移動処理
    void GobackStageSelect()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
}

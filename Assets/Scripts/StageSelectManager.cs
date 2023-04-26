using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ステージ選択ボタン
    public void PushStageSelectButton (int stageNo)
    {
        // ゲームシーン移行
        SceneManager.LoadScene("PuzzleScene" + stageNo);
    }
}

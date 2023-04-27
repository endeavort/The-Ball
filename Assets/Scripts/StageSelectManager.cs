using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectManager : MonoBehaviour
{
    public GameObject[] stageButtons; // ステージ選択ボタン配列

    // Start is called before the first frame update
    void Start()
    {
        // どのステージまでクリアしているのかをロード（セーブ前なら0)
        int clearStageNo = PlayerPrefs.GetInt("CLEAR", 0);

        // ステージボタンの有効化
        for (int i = 0; i <= stageButtons.GetUpperBound (0); i++)
        {
            bool b;

            if (clearStageNo < i)
            {
                b = false;
            }
            else
            {
                b = true;
            }

            // ボタンの有効/無効を設定
            stageButtons[i].GetComponent<Button>().interactable = b;
        }
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

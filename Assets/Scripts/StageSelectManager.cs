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

    // �X�e�[�W�I���{�^��
    public void PushStageSelectButton (int stageNo)
    {
        // �Q�[���V�[���ڍs
        SceneManager.LoadScene("PuzzleScene" + stageNo);
    }
}

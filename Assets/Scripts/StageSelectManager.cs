using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectManager : MonoBehaviour
{
    public GameObject[] stageButtons; // �X�e�[�W�I���{�^���z��

    // Start is called before the first frame update
    void Start()
    {
        // �ǂ̃X�e�[�W�܂ŃN���A���Ă���̂������[�h�i�Z�[�u�O�Ȃ�0)
        int clearStageNo = PlayerPrefs.GetInt("CLEAR", 0);

        // �X�e�[�W�{�^���̗L����
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

            // �{�^���̗L��/������ݒ�
            stageButtons[i].GetComponent<Button>().interactable = b;
        }
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BreakOutManager : MonoBehaviour
{
    private GameObject[] blocks = new GameObject[90];
    public GameObject gameOverUI;
    public GameObject gameClearUI;
    public Animator ballAnimator;
    [SerializeField] TextMeshProUGUI levelValue = default;

    private int level = 1;

    private bool isClear = false;

    private int[] blocksList1 = {
        0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0,
        1, 0, 1, 0, 1, 0, 1, 0, 1,
        0, 1, 0, 1, 0, 1, 0, 1, 0,
        1, 0, 1, 0, 1, 0, 1, 0, 1,
        0, 1, 0, 1, 0, 1, 0, 1, 0,
        1, 0, 1, 0, 1, 0, 1, 0, 1,
        0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0
    };

    private int[] blocksList2 = {
        0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 2, 2, 0, 2, 2, 0, 0,
        0, 2, 1, 1, 2, 1, 1, 2, 0,
        0, 2, 1, 1, 1, 1, 1, 2, 0,
        0, 2, 1, 1, 1, 1, 1, 2, 0,
        0, 0, 2, 1, 1, 1, 2, 0, 0,
        0, 0, 0, 2, 1, 2, 0, 0, 0,
        0, 0, 0, 0, 2, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0
    };

    private int[] blocksList3 = {
        0, 2, 0, 0, 0, 0, 2, 0, 0,
        0, 2, 0, 0, 0, 2, 0, 2, 0,
        0, 2, 0, 0, 0, 2, 2, 2, 0,
        0, 2, 2, 2, 0, 2, 0, 2, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 2, 2, 0, 2, 2, 2, 0,
        0, 2, 0, 0, 0, 0, 2, 0, 0,
        0, 0, 2, 0, 0, 0, 2, 0, 0,
        0, 0, 0, 2, 0, 0, 2, 0, 0,
        0, 2, 2, 0, 0, 0, 2, 0, 0
    };

    // Start is called before the first frame update
    void Start()
    {
        // block生成
        setBlock(blocksList1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("BreakOut");
        }            

        // 終了判定
        if(isClear != true)
        {
            if(DestroyAllBlocks())
            {
                // クリア
                gameClearUI.SetActive(true);
                isClear = true;
            }
        }
    }

    private void setBlock(int[] list)
    {
        // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject sphere_prefab = Resources.Load<GameObject>("Block");
        for(int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 9; i++)
            {
                if(list[j*9+i] != 0)
                {
                    blocks[j*9+i] = Instantiate(sphere_prefab);
                    blocks[j*9+i].transform.position = new Vector3(-6.17f + 0.5f * j, 0.3f, -4.0f + 1.0f * i);
                }
            }
        }
    }

    // 終了判定
    private bool DestroyAllBlocks()
    {
        foreach(GameObject b in blocks)
        {
            if(b != null)
            {
                return false;
            }
        }
        if(level == 3){
            return true;
        } else if(level == 2) {
            setBlock(blocksList3);
            // ボールを透明にするアニメーション
            ballAnimator.SetBool ( "color", true );
        } else {
            setBlock(blocksList2);
        }
        level += 1;
        levelValue.text = level.ToString();
        return false;
    }

    // gameover
    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    // ボタン押したら早送り

    // リセット
    public void GameRestart()
    {
        SceneManager.LoadScene("BreakOut");     // シーン名    
    }

    // Menuに戻る
    public void moveMain()
    {
        SceneManager.LoadScene(0);     // シーンindex  
    }
}

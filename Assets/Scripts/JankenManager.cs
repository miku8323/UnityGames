using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JankenManager : MonoBehaviour
{
    private string enemyHand = "none";
    private string myHand = "none";
    private bool isGame = false;

    private float time;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGame){
            time += Time.deltaTime;
            Debug.Log(time);
        }

        // start
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isGame = true;
            time = 0.0f;
            count = 0;
            //janken();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myHand = "グー";
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myHand = "チョキ";
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myHand = "パー";
        }
    }

    // リセット
    public void GameRestart()
    {
        SceneManager.LoadScene("Janken");     // シーン名    
    }

    // Menuに戻る
    public void moveMain()
    {
        SceneManager.LoadScene(0);     // シーンindex  
    }

    public void janken()
    {
        // アニメーション色々（人、文字）
            
        int rnd = Random.Range(1,4);

        switch(rnd)
        {
            case 1:
                enemyHand = "グー";
                break;
            case 2:
                enemyHand = "チョキ";
                break;
            case 3:
                enemyHand = "パー";
                break;
        }
    }
}

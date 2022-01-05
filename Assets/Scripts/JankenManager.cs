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
    private int myCount = 0;
    private int enemyCount = 0;

    public Animator myAnimator;
    public Animator enemyAnimator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isGame){
            time += Time.deltaTime;
        }

        // start
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isGame = true;
            myCount = 0;
            enemyCount = 0;
            startJanken();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myHand = "グー";
            myAnimator.SetBool ( "gu", true );
            myAnimator.SetBool ( "choki", false );
            myAnimator.SetBool ( "pa", false );
            myAnimator.SetBool ( "none", false );
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myHand = "チョキ";
            myAnimator.SetBool ( "gu", false );
            myAnimator.SetBool ( "choki", true );
            myAnimator.SetBool ( "pa", false );
            myAnimator.SetBool ( "none", false );
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myHand = "パー";
            myAnimator.SetBool ( "gu", false );
            myAnimator.SetBool ( "choki", false );
            myAnimator.SetBool ( "pa", true );
            myAnimator.SetBool ( "none", false );
        }

        if(time > 1.8f)
        {
            judge();
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

    public void judge()
    {
        time = 0.0f;
        myAnimator.SetBool ( "janken", false );
        enemyAnimator.SetBool ( "janken", false );

        if(myHand == "グー"){
            switch(enemyHand)
            {
                case "グー":
                    Debug.Log("あいこ");
                    break;
                case "チョキ":
                    Debug.Log("勝ち");
                    myCount += 1;
                    enemyCount = 0;
                    break;
                case "パー":
                    Debug.Log("負け");
                    myCount = 0;
                    enemyCount += 1;
                    break;
            }
        } else if(myHand == "チョキ") {
            switch(enemyHand)
            {
                case "グー":
                    Debug.Log("負け");
                    myCount = 0;
                    enemyCount += 1;
                    break;
                case "チョキ":
                    Debug.Log("あいこ");
                    break;
                case "パー":
                    Debug.Log("勝ち");
                    myCount += 1;
                    enemyCount = 0;
                    break;
            }
        } else if(myHand == "パー") {
            switch(enemyHand)
            {
                case "グー":
                    Debug.Log("勝ち");
                    myCount += 1;
                    enemyCount = 0;
                    break;
                case "チョキ":
                    Debug.Log("負け");
                    myCount = 0;
                    enemyCount += 1;
                    break;
                case "パー":
                    Debug.Log("あいこ");
                    break;
            }
        } else {
            Debug.Log("遅い");
            myCount = 0;
            enemyCount += 1;
        }

        if(myCount > 2 || enemyCount > 2)
        {
            // 終了判定
        } else {
            // 続行
            Invoke("janken", 1.0f);
        }
    }

    // ジャンケンゲーム
    public void startJanken()
    {
        janken();
    }

    // ジャンケン1回分
    public void janken()
    {
        time = 0.0f;

        // アニメーション（人）
        myHand = "none";
        myAnimator.SetBool ( "none", true );
        myAnimator.SetBool ( "gu", false );
        myAnimator.SetBool ( "choki", false );
        myAnimator.SetBool ( "pa", false );

        myAnimator.SetBool ( "janken", true );
        enemyAnimator.SetBool ( "janken", true );

        // アニメーション（文字など）


        int rnd = Random.Range(1,4);
        switch(rnd)
        {
            case 1:
                enemyHand = "グー";
                enemyAnimator.SetBool ( "gu", true );
                enemyAnimator.SetBool ( "choki", false );
                enemyAnimator.SetBool ( "pa", false );
                break;
            case 2:
                enemyHand = "チョキ";
                enemyAnimator.SetBool ( "gu", false );
                enemyAnimator.SetBool ( "choki", true );
                enemyAnimator.SetBool ( "pa", false );
                break;
            case 3:
                enemyHand = "パー";
                enemyAnimator.SetBool ( "gu", false );
                enemyAnimator.SetBool ( "choki", false );
                enemyAnimator.SetBool ( "pa", true );
                break;
        }
    }
}

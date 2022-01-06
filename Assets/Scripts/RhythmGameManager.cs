using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
using TMPro;

public class RhythmGameManager : MonoBehaviour
{
    [SerializeField] PlayableDirector playableDirector;
    [SerializeField] TextMeshProUGUI ScoreValue = default;
    [SerializeField] TextMeshProUGUI resultScore = default;
    [SerializeField] TextMeshProUGUI countDownText = default;
    [SerializeField] GameObject resultPanel = default;
    int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameMain());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator GameMain()
    {
        // count down
        countDownText.text = "3";     // 3
        yield return new WaitForSeconds(1);
        countDownText.text = "2";     // 2
        yield return new WaitForSeconds(1);
        countDownText.text = "1";     // 1
        yield return new WaitForSeconds(1);
        countDownText.text = "START!";     // Start
        yield return new WaitForSeconds(0.3f);
        countDownText.text = "";
        playableDirector.Play();
    }

    // ゲーム終了
    public void OnEndEvent()
    {
        resultScore.text = score.ToString();
        resultPanel.SetActive(true);
    }

    // スコア
    public void AddScore(int point)
    {
        score += point;
        ScoreValue.text = score.ToString();
        Debug.Log(score);
    }

    // リセット
    public void GameRestart()
    {
        SceneManager.LoadScene("RhythmGame");     // シーン名    
    }

    // Menuに戻る
    public void moveMain()
    {
        SceneManager.LoadScene(0);     // シーンindex  
    }
}

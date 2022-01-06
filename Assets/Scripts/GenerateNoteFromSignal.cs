using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNoteFromSignal : MonoBehaviour
{
    [SerializeField] noteManager note_prefab;

    // ド
    public void generateNoteC()
    {
        Instantiate(note_prefab, new Vector3(-3, 0, 8), Quaternion.identity);
    }

    // レ
    public void generateNoteD()
    {
        Instantiate(note_prefab, new Vector3(-2, 0, 8), Quaternion.identity);
    }

    // ミ
    public void generateNoteE()
    {
        Instantiate(note_prefab, new Vector3(-1, 0, 8), Quaternion.identity);
    }

    // ファ
    public void generateNoteF()
    {
        Instantiate(note_prefab, new Vector3(0, 0, 8), Quaternion.identity);
    }

    // ソ
    public void generateNoteG()
    {
        Instantiate(note_prefab, new Vector3(1, 0, 8), Quaternion.identity);
    }

    // ラ
    public void generateNoteA()
    {
        Instantiate(note_prefab, new Vector3(2, 0, 8), Quaternion.identity);
    }

    // シ
    public void generateNoteB()
    {
        Instantiate(note_prefab, new Vector3(3, 0, 8), Quaternion.identity);
    }
}

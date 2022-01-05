using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNoteFromSignal : MonoBehaviour
{
    [SerializeField] noteManager note_prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NoteEvent()
    {
        generateNote();
    }

    private void generateNote()
    {
        Instantiate(note_prefab, new Vector3(0, 0, 8), Quaternion.identity);
    }
}

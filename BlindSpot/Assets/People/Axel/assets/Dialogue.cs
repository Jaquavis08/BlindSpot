using UnityEngine;
using System.Collections.Generic;
using System;

[Serializable]
public struct DialoguePiece
{
    public string name;
    [TextArea] public string dialogue;
}


public class Dialogue : MonoBehaviour
{
    public List<DialoguePiece> dialogue;

    public TMPro.TMP_Text dialogueName;
    public TMPro.TMP_Text dialogueText;

    public void StartDialogue()
    {
        gameObject.SetActive(true);

        dialogueName.SetText("testing");
        dialogueText.SetText("testing");
    }
}

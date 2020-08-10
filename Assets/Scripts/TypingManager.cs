using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TypingManager : MonoBehaviour
{


    public List<word> words;

    void Start()
    {

    }


    void Update()
    {

    }
}



[System.Serializable]
public class word
{
    public string text;
    public UnityEvent onTyped;
    string hasTyped;
    int currentChar;
    int number = 3;

    public word(string t)
    {
        text = t;
        hasTyped = "";
        currentChar = 0;
    }


    public bool contintueText(char c)
}


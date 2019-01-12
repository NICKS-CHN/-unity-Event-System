using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void OnEnable()
    {
        GameEventCenter.AddListener(GameEvent.TestEvent, ShowLog);//register
    }

    void OnDisable()
    {
        GameEventCenter.RemoveListener(GameEvent.TestEvent, ShowLog); //dispose

    }

    void OnGUI()
    {
        if(GUI.Button(new Rect(100,100,200,200), "button"))
        {
            GameEventCenter.SendEvent(GameEvent.TestEvent);
        }
    
    }

    private void ShowLog()
    {
        Debug.Log("hello world!");
    }
}

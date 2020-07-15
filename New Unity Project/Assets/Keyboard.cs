using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;

    public void SelectButton()
    {
        this.keyboard = TouchScreenKeyboard.Open("キーボードに最初に入れておくテキスト", TouchScreenKeyboardType.Default);
        //後から変更も可能
        this.keyboard.text = "キーボードに入れるテキスト";
    }

    void Update()
    {
        if (keyboard != null && keyboard.status == TouchScreenKeyboard.Status.Done)
        {
            //print("入力値: " + keyboard.text);
        }

    }
}

﻿using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusButton : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //ここにタップされた時の処理を書く
            SceneManager.LoadScene("TODOsakuseiScene");
        }

    }
}

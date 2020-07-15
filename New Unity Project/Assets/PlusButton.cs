using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusButton : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("TODOsakuseiScene");
    }
}

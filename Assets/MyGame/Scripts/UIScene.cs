using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScene : MonoBehaviour
{
    public void OnButtonClick(string level)
    {
        SceneManager.LoadScene(level);
    }
}

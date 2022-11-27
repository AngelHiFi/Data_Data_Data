using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    //Это обработчик сцены главного меню.

    [SerializeField] Text PlayerNameInput;


    // привязываем к кнопке старт
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // привязываем к полю ввода InputField
    public void SetPlayerName()
    {
        PlayerDataHandle.Instance.PlayerName = PlayerNameInput.text;
    }

    //привязываем к кнопке выход
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}

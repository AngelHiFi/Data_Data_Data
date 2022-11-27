using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    //Статический класс для сохранения текущих данных игрока;
    public static PlayerDataHandle Instance;
    public string PlayerName;                 // имя игрока
    public int Score;                         // очки

    private void Awake()
    {
        
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}



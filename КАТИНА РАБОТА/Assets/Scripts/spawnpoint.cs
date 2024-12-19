using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // Публичная переменная для задания точки спавна через редактор Unity
    public Transform spawnPoint;

    // Объект игрока, который вы хотите спавнить
    public GameObject playerPrefab;

    void Start()
    {
        // Создаем копию объекта игрока в точке спавна с исходным вращением
        GameObject Player = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);

        // Дополнительные настройки для объекта игрока, если требуется
    }
}
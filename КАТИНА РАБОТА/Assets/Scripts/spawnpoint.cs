using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // ��������� ���������� ��� ������� ����� ������ ����� �������� Unity
    public Transform spawnPoint;

    // ������ ������, ������� �� ������ ��������
    public GameObject playerPrefab;

    void Start()
    {
        // ������� ����� ������� ������ � ����� ������ � �������� ���������
        GameObject Player = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);

        // �������������� ��������� ��� ������� ������, ���� ���������
    }
}
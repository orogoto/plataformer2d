using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Player")]
    public GameObject player;

    [Header("Enemies")]
    public List<GameObject> enemies;

    public void Awake()
    {
        if (Instance == null)
        Instance = this;
        else
            Destroy(gameObject);
    }

}

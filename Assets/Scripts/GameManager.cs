using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int playerHealthInstanciated;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            playerHealthInstanciated = 100;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addPlayerWunds()
    {
        instance.playerHealthInstanciated -= 10;
    }
    public void addPlayerHealing()
    {
        instance.playerHealthInstanciated += 20;
    }
    public static int getPlayerHealth()
    {
        return instance.playerHealthInstanciated;
    }
}

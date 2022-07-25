using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()          
    {
        int numGameSessions = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

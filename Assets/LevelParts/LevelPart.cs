﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TestList : List<Vector2> { }
public class LevelPart : MonoBehaviour
{
    public List<GameObject> TileMaps;
    public List<GameObject> spawnPositions;
    public GameObject TM_obstacle;
    public GameObject TM_oneSidePlateform;
    public GameObject TM_BackGround;
    public List<Vector4> lSpawnDifficulty = new List<Vector4>();
    //public Dictionary<int, Vector2> lSpawnDifficulty = new Dictionary<int, Vector2>();
      
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventHandler : MonoBehaviour
{
    public BoxCollider2D col;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DesactivateCollider()
    {
        col.enabled = false;
    }

    public void DestroyOnEnd()
    {
        
        Destroy(go);
    }
}

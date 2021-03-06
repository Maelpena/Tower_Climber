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

    public void Attack()
    {
        go.GetComponent<ShootingEnemy>().SpawnAndSetABullet();
    }
    public void EndOfAnimation()
    {
        go.GetComponent<ShootingEnemy>().EndOfAttack();
    }
    public void MakeKnockBack()
    {
        go.GetComponent<ShootingEnemy>().AddKnockback();
    }
}

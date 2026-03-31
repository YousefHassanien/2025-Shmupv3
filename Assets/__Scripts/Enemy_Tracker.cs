using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Tracker : Enemy 
{
    [Header("Tracker Settings")]
    public float trackingSpeed = 5f;
    private Transform heroTransform;

    void Start()
    {
        GameObject hero = GameObject.Find("_hero");
        if (hero != null)
        {
            heroTransform = hero.transform;
        }
    }

    public override void Move()
    {
        if (heroTransform == null)
        {
            base.Move(); 
            return;
        }

        Vector3 pos = transform.position;
        pos = Vector3.MoveTowards(pos, heroTransform.position, trackingSpeed * Time.deltaTime);
        transform.position = pos;
    }
}
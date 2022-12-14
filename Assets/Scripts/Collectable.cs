using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{
    // Logic
    private bool isCollected;

    protected override void OnCollide(Collider2D collider)
    {
        if (collider.name != "Player") return;
        if (isCollected) return;

        OnCollect();
    }

    protected virtual void OnCollect()
    {
        isCollected = true;
    }
}
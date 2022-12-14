using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;

    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        // Collision work
        boxCollider.OverlapCollider(filter, hits);

        for (var i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
            {
                continue;
            }

            OnCollide(hits[i]);

            // The array is not cleaned up, clean it up
            hits[i] = null;
        }
    }

    protected virtual void OnCollide(Collider2D collider)
    {
        Debug.Log("OnCollide isn't implemented in " + this.name);
    }
}
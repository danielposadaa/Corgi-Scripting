using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class FondoUPB : MonoBehaviour
{
    public Sprite backgroundImage;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U) && Input.GetKeyDown(KeyCode.P) && Input.GetKeyDown(KeyCode.B))
        {
            spriteRenderer.sprite = backgroundImage;
        }
    }
}


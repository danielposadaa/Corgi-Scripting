using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;


public class FondoUPB : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private string _sequence = "";

    public Sprite firstImage;
    public Sprite secondImage;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = firstImage;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                _sequence += "U";
            }
            else if (Input.GetKeyDown(KeyCode.P))
            {
                _sequence += "P";
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                _sequence += "B";
            }
        }

        if (_sequence == "UPB")
        {
            _spriteRenderer.sprite = secondImage;
            _sequence = "";
        }
    }
}



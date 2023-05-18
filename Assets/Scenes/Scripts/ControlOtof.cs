using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;


public class ControlOtof : MonoBehaviour
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
            if (Input.GetKeyDown(KeyCode.V))
            {
                _sequence += "V";
            }
            else if (Input.GetKeyDown(KeyCode.V))
            {
                _sequence += "V";
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                _sequence += "L";
            }
        }

        if (_sequence == "VVL")
        {
            _spriteRenderer.sprite = secondImage;
            _sequence = "";
        }
    }
}

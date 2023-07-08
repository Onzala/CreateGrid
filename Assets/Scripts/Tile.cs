using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _basecolor,_offsetcolor;
    [SerializeField] private SpriteRenderer _renderer;

    public void Init(bool isOffset) {
        _renderer.color = isOffset ? _offsetcolor : _basecolor;
    }

}

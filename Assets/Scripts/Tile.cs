using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _basecolor, _offsetcolor; //設置顏色變數
    [SerializeField] private SpriteRenderer _renderer; //設置渲染器變數
    [SerializeField] private GameObject _highlight; //設置遊戲物件變數

    public void Init(bool isOffset) { 
        _renderer.color = isOffset ? _offsetcolor : _basecolor;
    }

    void OnMouseEnter() {
        _highlight.SetActive(true);
    }
    void OnMouseExit() {
        _highlight.SetActive(false);
    }
}

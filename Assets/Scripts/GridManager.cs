using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height; //宣告長、寬變數

    [SerializeField] private Tile _tilePrefab; //建立預置物件(Prefab)參數

    [SerializeField] private Transform _cam; //建立參數移動鏡頭
    
    void Start() {  //在開始時執行
        GenerateGrid(); //這串的用途應該是執行GenerateGrid()這個功能
    }
    void GenerateGrid() { //生成板塊的功能
        for (int x = 0; x<_width; x++) {  //迴圈：宣告X=0，如果X<_width,則增加X的數值(但不知為何是增加整數)
            for (int y = 0; y<_height; y++) {  //迴圈：宣告Y=0，如果Y<_height,則增加y的數值(但不知為何是增加整數)
                var spawnedTile = Instantiate(_tilePrefab,new Vector3(x,y),Quaternion.identity); //只知道這一段式生成板塊，但不知程式語言的用途
                spawnedTile.name = $"Tile {x} {y}"; //生成板塊的名稱

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0); //
                spawnedTile.Init(isOffset);
            } 
        }


        _cam.transform.position = new Vector3((float)_width/2 -0.5f,(float)_height/2 -0.5f,-10 );
    }
}

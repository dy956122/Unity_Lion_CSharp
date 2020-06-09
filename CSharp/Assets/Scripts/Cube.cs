using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 立方體：繼承 形狀類別
/// 繼承可擁有父類別的公開成員
/// 可存取公開的成員
/// </summary>
public class Cube : Shape
    // 原本的MonoBehavior就是用於繼承的子類別，按下F12可以看到相關的資料
{
    private void Start()
    {
        print(gameObject + "體積：" + GetVolume());
    }
}

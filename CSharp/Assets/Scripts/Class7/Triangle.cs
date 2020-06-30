using UnityEngine;

/// <summary>
/// 三角形 繼承 形狀
/// 三角形體積需要覆寫
/// </summary>
public class Triangle : Shape
{
    /// <summary>
    /// override 覆寫：覆寫父類別
    /// 另一邊的腳本需要加上virtual，才能在這邊加上override做多型的修改
    /// </summary>
    /// <returns></returns>
    public override float GetVolume()
    {
        volume = length * width * height / 2; // 三角形體積
        return volume;
    }

    private void Start()
    {
        print(gameObject + "體積：" + GetVolume());
    }
}

using UnityEngine;

public class Fly : Monster
{
    [Header("飛行範圍"), Range(1, 30)]
    public float range;

    /// <summary>
    /// 飛行
    /// </summary>
    private void FlyAway()
    {
        // Time.timeSinceLevelLoad 載入後的遊戲時間 從 0 增加 , 如果速度太慢, 可在後面乘 一些數字
        // Mathf.Sin() 曲線
        transform.Translate(0, range * Time.deltaTime * Mathf.Sin(Time.timeSinceLevelLoad * 5), 0);
    }

    protected override void Update() 
    {
        base.Update(); // 保留父類別內容
        FlyAway();
    }
}

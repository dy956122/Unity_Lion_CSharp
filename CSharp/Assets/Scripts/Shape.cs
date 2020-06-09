using UnityEngine;

public class Shape : MonoBehaviour // 被Cube、Triangle 腳本繼承
{
    #region 基礎欄位與屬性
    /// <summary>
    /// 形狀：基底類別
    /// </summary>
    [Header("長寬高")]
    public float length;
    public float width;
    public float height;

    /// <summary>
    /// 體積
    /// protected 保護：允許子類別存取，禁止外部存取，詳情可以看老師在Dropbox Paper的講義
    /// </summary>
    protected float volume;

    #endregion 基礎欄位與屬性 結束


    /// <summary>
    /// 取得體積
    /// virtual 虛擬： 允許子類別覆寫
    /// 需要在底下的float、void 前面加上 virtual，另外一邊的腳本才能用override做修改
    /// </summary>
    /// <returns>體積</returns>
    public virtual float GetVolume() // 取得體積
    {
        volume = length * width * height;
        return volume;
    } // 取得體積 結束
}

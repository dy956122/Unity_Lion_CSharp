using UnityEngine;

// 註解 用來說明 、 紀錄 ... 只會在此腳本內看到
// 摘要 Summary : 描述此內容,會在其他腳本內看到,提高維護性及擴充性(可讀性),請打3個/
// 新增的C# 放在專案內為藍圖
// 放在場景物件上為實體物件
/// <summary>
/// 定義汽車物件
/// </summary>
public class Car : MonoBehaviour
{
    // 認識第一個成員 : 欄位 field - 儲存物件資料
    // 資料類型
    // CC數      - 2000         - 整數 int
    // 重量      - 100.9        - 浮點數 float
    // 品牌      - BMW          - 字串(文字) String
    // 剎車      - 是否開啟      - 布林值 bool - true 、 false

    // 定義欄位語法:
    // 修飾詞 資料類型 欄位名稱(指定 值);

    // 修飾詞:
    // 公開 public : 允許其他類別存取,顯示在屬性面板 (Inspector)
    // 私人 private(預設) : 不允許 、 不顯示

    // 預設值
    // int 、 float 為 0
    // String 為 ""
    // bool 為 false
    // 欄位資料 Attribute: Unity 提供用於輔助欄位的功能
    // 語法: [屬性名稱(值)]
    // 標題 [Header("字串")]
    // 提示 [Tooltips("字串")]
    // 範圍 [Range(最小值,最大值] - 僅限於數值類型資料 int、 float
    
    /// <summary>
    /// 汽車的CC數 
    /// </summary>
    [Header("汽車的CC數"),Range(500,5000)]
    public int cc = 2000 ;
    /// <summary>
    /// 汽車重量
    /// </summary>
    [Tooltip("這個欄位是用來存放汽車的噸位")]
    [Range(50,350)]
    public float weight = 100.9f ;
    /// <summary>
    /// 品牌
    /// </summary>
    [Header("品牌")]
    [Tooltip("代表這台車子的品牌")]
    public string brand = "BMW" ;
    /// <summary>
    /// 是否剎車
    /// </summary>
    [Header("是否煞車") ,Tooltip("用來儲存這台車子目前是否為剎車狀態")]
    public bool brake = false ; // 也可寫成 bool brake; ,因為預設值是false
}

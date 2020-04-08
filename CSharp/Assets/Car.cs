using UnityEngine;

// 註解 用來說明 & 紀錄 ... 只會在此腳本內看到
// 摘要 Summary : 描述此內容,會在其他腳本內看到,提高維護性及擴充性,請打///
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
    // 剎車      - 是否開啟      - 布林值 bool - true ` false

    // 定義欄位語法:
    // 資料類型 欄位名稱(指定 值);
    // 預設值
    // int & float 為0
    // String 為""
    // bool 為 false

    int cc = 2000 ;
    float weight = 100.9f ;
    string brand = "BMW" ;
    bool brake = false ; // 也可寫成 bool brake,因為預設值是false
}

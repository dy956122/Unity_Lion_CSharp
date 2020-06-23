using UnityEngine;

public class Ship : MonoBehaviour
{

    // 公開欄位：給任何人存取
    // 從其他類別取得或存放資料
    public float speed = 20f;

    // 私人欄位：僅限於此類別存取
    // 從其他類別無法取得或存放資料
    // private float weight = 50f;

    // 問題：
    // 假設需要取得但是不能修改 - 屬性 (權限) -－> 不想被外部修改的資料
    // 打prop 再按 兩下 tab 鍵,即可使用 get跟 set再重新命名
    // 屬性語法
    // 修飾詞 類型 名稱 { 存取權限 }
    // get 可以取得
    // set 可以存放
    // 讀寫權限屬性
    // 屬性不會顯示在屬性面板上 (ODIN - UnityEditor)
    public float length { get; set; }

    // 企劃：寬度固定 30 不變
    // 封裝欄位：
    // 1. 私人欄位：
    // 2.唯獨屬性 (return 私人欄位)
    // 封裝在大型專案才會使用
    // 舊版寫法
    private float _width = 30; //前面加 _ 使檔名不重複
    //唯獨屬性：不能設定值 (沒有set)
    public float width { get { return _width; } }

    // 企劃：寬度固定 30 不變
    private float _height = 10.5f;

    // => (黏巴達 Lambda)
    // C# 6版以上的用法 | Unity 2017 C# 已改為 7 版
    // C# 目前2020年改為 8版
    // get => _height; 等同於 get { retuen _height; }
    public float height { get => _height; }

    private float lv = 3;

    // 企劃：攻擊力等於　攻擊力　＊　等級
    // 封裝欄位：
    // 1. 私人欄位：
    // 2.唯獨屬性 (return 私人欄位)  {私人欄位 = Value}
    // value 設定屬性時給予的值
    private float _atk;
    public float atk { get { return _atk; } set { _atk = value * lv; } }

    // 使用快速完成的黏巴達寫法 52行 跟 56行 寫法是一樣的
    private float _def;
    public float def { get => _def; set => _def = value * lv; }


}

using UnityEngine;

// 定義列舉
// 定義在類別外可以讓所有類別使用
// 列舉預設為整數，從 0 開始
// 春天 0，夏天 1...
// 製作方法：用鍵盤打 en就會自動跑出enum，再按兩下tab就會自動生成，直接改名後，按下Enter就可以開始列舉
public enum Season
{
    Spring, Summer, Fall, Winter
}

public enum State
{
    Idle, Walk, Attack, Damage, Skill, Dead
}

// 自行變更編號
public enum Day
{
    Sunday = 7, Monday = 1, Tuesday, Wensday, Thursday, Friday, Saturday
}

public class Class4_PropArrayEnum : MonoBehaviour
{
    // 使用列舉
    // 修飾詞 列舉名稱 自訂名稱
    public Season _season;
    public State _state;
    public Day _day = Day.Wensday;

    #region 練習陣列
    public Ship ship;

    //  一般欄位
    public string name1 = "KID";
    public string name2 = "50大大";
    public string name3 = "亮亮大大";

    // 陣列：類型[]
    // 屬性面板上 size 指的是數量
    // 屬性密版上的 Element 為陣列成員 編號從 0 開始
    public string[] names; // 宣告陣列不指定數量

    public float[] weights = new float[3];  // 宣告陣列並指定數量

    public int[] scores = new int[] { 10, 20, 50, 90 }; // 宣告陣列並指定內容

    public bool[] mission = { true, false, true, false }; // 宣告陣列並指定內容，此寫法較短，較為常用

    #endregion

    // 喚醒事件：Start 之前執行一次
    private void Awake()
    {
        // 取得列舉
        print("季節：" + _season);
        print("狀態：" + (int)_state); // (int) 將列舉轉型為整數
        print("日期：" + (int)_day);
        // 存放列舉
        _state = State.Walk;
    }

    private void Start()
    {
        //設定屬性
        ship.length = 99.9f;
        //取得屬性
        print(ship.length);

        //設定唯獨屬性：錯誤
        // ship.width = 20.5f; //會出現錯誤
        // 取得唯獨屬性
        print("船的寬度：" + ship.width);

        ship.atk = 50.3f;
        print("船的攻擊力" + ship.atk);

        ship.def = 10.1f;
        print("船的防禦力：" + ship.def);

        // 指定陣列資料
        // 預設值為0，執行時才會浮現
        names = new string[] { "怪物A", "怪物B", "怪物C" };

        // 陣列[編號] - 注意編號從 0 開始
        // 陣列存放

        scores[0] = 77;

        // 陣列取得
        print("取得怪物陣列第三筆資料" + names[2]);
        // 陣列常見錯誤：編號超出範圍
        // print("取得怪物陣列第三筆資料" + names[3]); 因為沒有第4個東西，會出現以下錯誤訊息
        // IndexOutOfRangeException

        // 陣列.Length 長度(數量)
        print("分數陣列的長度(數量)" + scores.Length);

        // 呼叫改變分數方法並將分數陣列傳進方法內
        ChangeScore(scores);
        TestValue(A);
        TestRefe(B);

    }



    // 陣列為參考類別
    /// <summary>
    /// 改變第二筆分數為 99 分
    /// </summary>
    /// <param name="theArray"></param>
    private void ChangeScore(int[] theArray)
    {
        theArray[1] = 99;
    }
    // 整數為實值行別
    public int A = 99;
    // 陣列為參數行別
    public int[] B = { 99 };

    /// <summary>
    /// 測試實值型別，傳值，傳資料進來，不會修改原本資料，意思就是只會回傳資料，不會把數值改掉
    /// </summary>
    /// <param name="test"></param>
    private void TestValue(int test)
    {
        test = 0;
    }

    /// <summary>
    /// 測試參考型別，傳址，傳地址進來，會修改原本資料
    /// </summary>
    /// <param name="test"></param>
    private void TestRefe(int[] test)
    {
        test[0] = 0;
    }
}

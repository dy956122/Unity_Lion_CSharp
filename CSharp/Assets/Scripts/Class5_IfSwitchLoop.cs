using UnityEngine;

public class Class5_IfSwitchLoop : MonoBehaviour
{
    [Header("是否開門")]
    public bool openDoor;
    [Header("分數")]
    public int score = 0;
    [Header("血量")]
    [Range(0, 100)]
    public int hp = 100;
    [Header("道具")]
    public string prop = "紅水";

    public Season _season;
    [Header("道具數量")]
    public int count;
    [Header("任務是否完成")]
    public bool complete;

    public string test;

    private int i = 1;
    private int j = 1;

    //GameObject 可存放階層面板或專案內的模型
    [Header("地板")]
    public GameObject cube;

    public int[] scores = { 100, 99, 88, 7, 66, 55 };

    private void CreateFloor(int length, int width)
    {
        // 巢狀迴圈
        // 注意初始值名稱不能相同
        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < length; i++)
            {
                // API 實例化 (生成)
                // 生成(物件,座標,角度)
                // Vector3 三維向量(保存三個浮點數)
                // Quaternion 角度 x,y,z, w(單位)
                // Quaternion.identity 零角度
                // Quaternion.Euler(x,y,z) 歐拉角度 - 0~360度
                Instantiate(cube, new Vector3(j * 2, 0, i * 2), Quaternion.Euler(270, 0, 0));
            }
        }

    }


    private void Awake()
    {

        CreateFloor(30, 3); // 此為呼叫生成地板的方法

        #region 老師範例：迴圈

        #region 老師範例 foreach 迴圈
        // foreach 迴圈會跟 陣列做搭配
        //使用for 迴圈取得陣列資料
        for (int i = 0; i < scores.Length; i++)
        {
            print("for 迴圈取資料：" + scores[i]);
        }

        // foreach 迴圈
        // 語法：foreach (取得資料的類型 取得資料的名稱 in 陣列) { 執行次數為陣列數量}
        foreach (int item in scores)
        {
            print("foreach 迴圈取資料：" + item);
        }

        #endregion  //老師範例 foreach 迴圈

        #region 老師範例：break 跟 return 迴圈
        /*
        for (int i = 0; i < 101; i++)
        {
            print("break 迴圈：" + i);

            // 如果 i 等於 10 就打斷迴圈並且執行迴圈下方的程式
            if (i == 10) break;
        }

        print("break 迴圈外的程式");
        */


        /*
        for (int i = 0; i < 101; i++)
        {
            print("return 迴圈：" + i);

            // 如果 i 等於 10 就跳出方法外，[此方法] 下方的程式段落皆不執行
            if (i == 10) return;
        }
        print("return 迴圈外的程式");
        */

        /*
        // 執行結果：0-4 6-19 迴圈外的程式，也就是說 中間的5 不執行
        for (int i = 0; i < 20; i++)
        {
            if (i == 5) continue;
            print("continue 迴圈：" + i);
        }
        print("continue 迴圈外的程式");
        */

        for (int i = 0; i < 10; i++)
        {
            // goto 標記名稱
            if (i == 5) goto Test;
            print("goto 迴圈：" + i);
        }
        
    // 標記名稱
    Test:
        // 標記陳述式
        print("這是標記陳述式");


        #endregion 老師範例：break 、 return 跟 continue 、 goto迴圈 結束

        #region While 迴圈
        // while 迴圈
        // while (布林值) {當布林值為 true 執行}
        // 切記 要輸入 i++，不然會因為無限次數執行，Unity會當掉
        // 迴圈之前評估：第一次判斷
        // 意思就是：做之前先評估看看要不要執行，確定才執行，也最常在遊戲業使用
        // 先加1，之後執行
        while (i <= 10)
        {
            print("while 迴圈第：" + i + "次");
            //print("生怪物" + "編號" + i + "次");
            i++;
        }
        #endregion


        #region do 迴圈
        // 迴圈之後評估，第一次判斷 j = 2;
        // 也就是先執行一次之後，j就加了1
        do
        {
            print("do 迴圈第：" + i + "次");
            j++;
        } while (j <= 10);
        #endregion

        #region for 迴圈
        // for (初始值,條件,迭代器)
        // 迭代器： i++
        for (int k = 1; k <= 10; k++)
        {
            print("for 迴圈第：" + k + "次");
        }

        for (int k = 10; k > 0; k--)
        {
            print("for 迴圈第：" + k + "次");
        }

        #endregion




        #endregion // 老師範例：迴圈  結束
    }


    void Start()
    {
        // if 判斷式
        // if (布林值) { 布林值 = true 時執行}
        if (true)
        {
            print("哈囉，我是if判斷式~");
        }
    }

    // 更新事件：一秒執行約 60 次 (60FPS)
    private void Update()
    {


        #region 老師上課 三元運算子 範例
        // 當道具數量 >= 5 任務完成 true
        // 三元運算子語法 - 布林運算式 ? 運算式A : 運算式 B
        // 指派、呼叫 = ()
        complete = (count >= 5) ? true : false;

        // 優點：省效能，缺點：不易讀
        test = score >= 60 ? "及格" : score >= 40 ? "補考" : "被當";
        #endregion

        #region 老師上課Switch範例
        // Switch 常常跟 列舉 一起用
        // 快捷：先輸入sw會動跳出switch，再按兩下 tab，
        // 然後輸入需要用到的 列舉 名稱，再按下 Enter 鍵，會自動產生
        // case 值或字串 + 冒號
        switch (prop)
        {
            case "紅水":
                print("補 HP~");
                break;
            case "藍水":
                print("補 MP~");
                break;
            case "黃水":
                print("補 EXP~");
                break;
            // default 可省略
            default:
                print("你吃錯道具了~!!");
                break;
        }

        switch (_season)
        {
            case Season.Spring:
                print("春");
                break;
            case Season.Summer:
                print("夏");
                break;
            case Season.Fall:
                print("秋");
                break;
            case Season.Winter:
                print("冬");
                break;
            default:
                break;
        }
        #endregion

        #region 老師上課if判斷式範例
        // 當openDoor 為 true 執行 {開門}
        // 當openDoor 為 false 執行 {關門}
        // if (OpenDoor == true )，平時預設值為true，所以即使略寫也沒關係

        #region 錯誤示範
        /* if (hp >= 70)
         {
             print("安全");
         }
         else if (hp < 70) 
         {
             print("警告");
         }else if (20< 70)
         {
             print("危險");
         }*/
        #endregion

        if (openDoor)
        {
            print("開門~");
        }
        else
        {
            print("關門~");
        }

        // 比較運算子、邏輯運算子結果為布林值
        // 大於 60 及格
        // 小於 60 不及格
        if (score >= 60)
        {
            print("及格~");
        }
        else if (score >= 40)
        {
            print("補考");
        }
        else if (score >= 20)
        {
            print("付錢補考～");
        }
        else
        {
            print("被當!!");
        }

        #endregion

        #region 上課練習用
        if (hp >= 70)
        {
            print("安全");
        }
        else if (hp >= 20)
        {
            print("警告");
        }
        else
        {
            print("危險");
        }
        #endregion
    }
}

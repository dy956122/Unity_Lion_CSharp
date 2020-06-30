using UnityEngine;
using System.Collections;               // ArrayList 
using System.Collections.Generic;       // List  - 泛型(進化版的ArrayList)  使用 集合必須要追加的段落

namespace KID.Class10
{
    public class Class10_Collection : MonoBehaviour
    {
        #region List、ArrayList
        // 陣列：一旦固定長度就不能改變
        public int[] scores = { 100, 90, 80, 70, 60 };

        // 集合：彈性
        // 清單
        public List<float> hp = new List<float> { 99.9f, 88.8f, 77.7f }; // List< 值 >，必須使用 new 來新增

        public List<float> hpResult = new List<float>();

        public ArrayList numbers = new ArrayList();

        // 排序 ( 製作排行榜的必備技能 )
        public List<int> count = new List<int> { 9, 100, 15, 77, 30, 99, 123 };

        private void Start()
        {
            // 1. 集合可以改變陣列長度
            hp.Add(66.6f);                  // 清單.增加(T)
            hp.Remove(88.8f);               // 清單.刪除(T)

            print("是否包含66.6：" + hp.Contains(66.6f)); // 是否包含(T)

            hpResult = hp.FindAll((x) => x >= 70f); ; // 搜尋所有(大於等於 70) 資料

            // ArrayList 與 List 差異
            // ArrayList 為 Object 型別：可存放所有類型
            // List 為泛型：一旦指定類型就只能存放一種類型 List<int> - int
            // ArrayList 不會顯示在屬性面板
            numbers.Add(100);
            numbers.Add(77.7f);
            numbers.Add("123");
            numbers.Add(true);  // 最後ArrayList的值會被這行取代

            count.Sort();       // 使清單內的數字由小到大排序
            count.Reverse();    // 反轉，使上方的數字大小排序顛倒
        }
        #endregion List、ArrayList
        #region 佇列 與 堆疊
        // 佇列
        // 1. 添加資料到尾端
        // 先進先出
        // 例子： 飲料店的隊伍
        // 先來的人先點飲料
        public Queue<int> lv = new Queue<int>();

        // 堆疊
        // 2. 添加資料到頂端
        // 先進後出
        // 例子：堆放椅子
        // 後面疊的椅子可以先拿
        // 應用於卡牌遊戲的抽卡區
        public Stack<int> n = new Stack<int>();

        public Queue<string> people = new Queue<string>();
        public Stack<string> box = new Stack<string>();

        private void Awake()
        {
            lv.Enqueue(10);             // 添加佇列資料
            lv.Enqueue(20);
            lv.Enqueue(30);

            foreach (var item in lv)
            {
                print("佇列的第一筆資料：" + item);
            }

            n.Push(10);                 // 添加堆疊資料
            n.Push(20);
            n.Push(30);

            foreach (var item in n)
            {
                print("堆疊的資料：" + item);
            }

            people.Enqueue("亮亮");
            people.Enqueue("50");
            people.Enqueue("KID");

            box.Push("盒子1號");
            box.Push("盒子2號");
            box.Push("盒子3號");

        }

        private void Update()
        {
            // 佇列.先進先出，底下的Alpha1 是指 鍵盤左上角的 數字1
            // Dequeue 是刪掉最早排列的資料(最早排隊的人)
            if (Input.GetKeyDown(KeyCode.Alpha1)) print("排隊的第一個人：" + people.Dequeue());
            // 堆疊.先進先出
            if (Input.GetKeyDown(KeyCode.Alpha2)) print("堆放的第一個箱子：" + box.Pop());
        }

        #endregion  佇列 與 堆疊 結束

        #region 雜湊表、字典
        // 兩個關鍵字
        // KEY、Value - 關鍵字、值
        // 雜湊表不會顯示在屬性面板上(Unity欄位)，需要使用 Odin 外掛

        // 差異：
        // 雜湊表 - 物件
        // 字典 - 泛型
        // 雜湊表
        public Hashtable player = new Hashtable();

        // 字典 - 關鍵字 (字串) ，值 (整數)
        public Dictionary<string, int> data = new Dictionary<string, int>();
     

        // 物件啟動時執行事件
        private void OnEnable()
        {
            player.Add("Lv", 99);               // Hashtable.Add("Key", Value);
            player.Add("Hp", 999);
            player.Add("Mp", 500);
            player.Add(true, true);             // ????

            // DictionaryEntry 結構 - 儲存 Key 與 Value
            foreach (DictionaryEntry item in player) // 請把 var 改成 DictionaryEntry
            {
                print("雜湊表資料 KEY：" + item.Key);
                print("雜湊表資料 VALUE：" + item.Value);
            }

            data.Add("短刀", 30);
            data.Add("長刀", 300);
            data.Add("屠龍刀", 3000);
            // data.Add(true,true); // 錯誤

            foreach (KeyValuePair<string,int> item in data)// 請把 var 改成 KeyValuePair<string,int>
            {
                print("字典的 KEY：" + item.Key);
                print("字典的 VALUE：" + item.Value);
            }

            // 用 陣列 或 清單 存取資料 只能透過 索引值 index - 0 1 2 3 4...
            // 用雜湊表語字典可以使用 Key 存取資料 - "屠龍刀"、"Lv"
            print("價格：" + data["屠龍刀"]);
            print("價格：" + player["Lv"]);
        }
        #endregion 雜湊表、字典 結束
    }

}

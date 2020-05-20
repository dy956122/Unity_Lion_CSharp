using UnityEngine; // 使用Unity 的API
// using UnityEngine.AI;   // 使用Unity 的AI API
public class Class6_StaticAPI : MonoBehaviour
{
    // 物件
    public Enemy Zombie1, Zombie2;

    // 非靜態成員通常是指 物件的某些屬性，像是 位置...之類的
    // 修飾詞 非靜態成員類別 物件名稱
    public GameObject obj1;

    public Light myLight;

    public Transform tran1;

    // Start is called before the first frame update
    void Start()
    {

        #region 練習靜態
        // 一般欄位
        // 取得方式：物件、欄位
        print(Zombie1.name + "血量" + Zombie1.hp);
        print(Zombie2.name + "血量" + Zombie2.hp);

        // 靜態欄位
        // 取得方式：類別.靜態欄位
        print("殭屍的速度：" + Enemy.speed);

        // 無法透過透件取得靜態欄位(錯誤)
        //print(Zombie1.speed);

        // 使用一般方法
        // 物件.方法
        Zombie1.Walk();
        Zombie2.Walk();

        // 使用靜態方法
        // 類別.靜態方法
        // 大家(同一族群)一起做一件事情
        Enemy.Stop();

        // 無法透過物件取得靜態方法 (會顯示錯誤)
        // Zombie1.Stop();

        #endregion 練習靜態 結束

        #region 靜態成員
        // API 靜態成員

        // 基本上都是public
        // 存放 靜態 屬性
        // 類別、靜態屬性 = 值
        Cursor.visible = false;

        // 取得 靜態 屬性
        // PI 是 唯讀 屬性
        print(Mathf.PI);

        // 取得 隨機 值
        // Random.value 值 的範圍 只在 0 ~ 1
        print(Random.value);

        // 使用靜態方法
        // 類別、靜態方法 (對應的引數)
        print("絕對值：" + Mathf.Abs(-77.7f));

        print("隨機範圍：" + Random.Range(1f, 100f));

        // 整數不傳回最大值
        print("隨機整數：" + Random.Range(1, 3));

        // API 官網的解釋必看

        #endregion 靜態成員 結束

        // 錯誤 ：非靜態不能透過被別存取
        //print(GameObject.layer);

        // 靜態屬性與非靜態屬性區別
        // 靜態屬性 不需要新增欄位 - Random.value
        // 非靜態欄位 需要新增新欄位 - public GameObject obj1; obj1.layer

        // 非靜態 屬性
        // 物件,非靜態屬性
        print("物件圖層：" + obj1.layer);

        // 非靜態 需要有實體物鍵 - 存在遊戲場景內的物件
        print("燈光顏色" + myLight.color);

        // tran1.localScale = new Vector3(5, 5, 5); 


        // tran1.localScale = new Vector3(1, 1, 1); 與下方的tran1.localScale = Vector3.one相同
        tran1.localScale = Vector3.one * 5;

    }



    // 偵測玩家輸入 - 約 60FPS
    private void Update()
    {

        // 原本用法：字串
        print("玩家是否按空白鍵" + Input.GetKey("space"));

        // 多載 1 ：列舉
        print("玩家是否按右鍵：" + Input.GetKeyDown(KeyCode.Mouse1));



        // 非靜態方法
        // 物件名稱.非靜態方法(對應的引數)
        tran1.Rotate(0, 0, 10 * Time.deltaTime);
    }


}

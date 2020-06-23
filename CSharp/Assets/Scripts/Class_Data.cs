using UnityEngine;

[System.Serializable] // 序列化：讓類別顯示在屬性面板。 類別不序列化是無法讓資料儲存的
public class Class_Data
{
    public string name;
    public int coin;
    public float hp;

    public Class_Data()
    {
        Debug.Log("空白的建構子~");
    }

    /// <summary>
    ///  設定所有資料：名稱、金幣與血量
    /// </summary>
    /// <param name="n">名稱</param>
    /// <param name="c">金幣</param>
    /// <param name="h">血量</param>
    public Class_Data(string n,int c,float h)
    {
        name = n;
        coin = c;
        hp = h;
    }
}

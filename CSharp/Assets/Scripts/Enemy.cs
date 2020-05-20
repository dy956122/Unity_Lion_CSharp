using UnityEngine; // 使用Unity 的API

public class Enemy : MonoBehaviour
{
    // 一般欄位(非靜態)
    // 屬於物件
    public float hp;

    // 靜態欄位
    // 屬於類別：所有物件共用
    // static 可加在public前面或後面
    // 也就是大家都一樣的數值
    public static float speed = 3;

    // 一般方法 (非靜態)
    public void Walk()
    {
        print(name + "走路中...");
    }

    // 靜態方法
    // 靜態方法內只能存取靜態成員
    // 只能使用加了 static的數值
    public static void Stop()
    {
        speed = 0;
        print("所有怪物的速度：" + speed);
    }
}

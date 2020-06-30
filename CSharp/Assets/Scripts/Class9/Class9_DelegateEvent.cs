using Unity.Mathematics;

using UnityEngine;

// 主要的用法：把方法當成參數傳遞
// ***簽名：方法的傳回類型、參數類型與參數數量*** (很重要---老師講義有提到，可以去看影片)
public class Class9_DelegateEvent : MonoBehaviour
{
    public void Addten(int number)
    {
        int n = number += 10;
        print("數字累加10：" + n);
    }

    public int number1 = 1;

    private void Awake()
    {
        Addten(9);
        Addten(number1);
    }

    public void MethodA()
    {
        print("我是方法A");
    }

    public void MethodB()
    {
        print("我是方法B");
    }


    // 簽名：無傳回、一個字串參數
    public void MethodC(string msg)
    {
        print("我是方法C - " + msg);
    }

    // 定義委派
    // 可以儲存 無傳回(void)、無參數的任何方法
    public delegate void DelegateTest();

    // 可以儲存 無傳回、一個字串參數的 任何方法
    public delegate void DelegateTest2(string s);

    // 委派的簽名：無傳回、一個參數、整數
    public delegate void DelegateTest3(int number);

    // 定義委派欄位
    public DelegateTest dA;
    public DelegateTest dB;
    public DelegateTest dC;

    public DelegateTest d;

    public DelegateTest2 d2C;

    public DelegateTest3 d3;

    private void Start()
    {
        dA = MethodA;           // dA 欄位儲存 方法A
        dA();                   // 呼叫 dA

        dB = MethodB;
        dB();

        // dC = MethodC;          // 不同簽名，無法儲存
        // dC();

        d2C = MethodC;            // 儲存 方法 C
        d2C("我是委派");

        d = MethodA;
        d += MethodB;             // 可無限一直加下去
        d += MethodB;

        // Lambda 匿名函式
        // () => { 陳述式 }
        // 使用此方法，可以省去一些方法宣告的打字量
        d += () =>
        {
            print("我是匿名函式喔~");
            print("我是匿名函式喔~");
        };

        d();

        // 上面的d3 有int的值，因此()內部也有要一個值
        d3 = (n) => { n *= 10;print("十倍後的數值：" + n); };
        d3(7);
    }
}

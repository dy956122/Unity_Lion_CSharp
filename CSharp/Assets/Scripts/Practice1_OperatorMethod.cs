using UnityEngine;
using UnityEngine.UI; //引用Unity 介面 命名空間
using System; // 引用 系統 命名空間(系統 API 字串轉整數), API 專用類別，給應用程式使用的指令碼

public class Practice1_OperatorMethod : MonoBehaviour
{
    //儲存兩筆資料
    public string number1;
    public string number2;

    [Header("文字：輸出結果")]
    public Text result;

    /// <summary>
    /// 給第一個欄位輸入使用
    /// </summary>
    /// <param name="number">第一個欄位的數值</param>
    public void InputNumber1(string number)
    {
        number1 = number;
    }

    /// <summary>
    /// 給第二個欄位輸入使用
    /// </summary>
    /// <param name="number">第二個欄位的數值</param>
    public void InputNumber2(string number)
    {
        number2 = number;
    }

    /// <summary>
    /// 加法
    /// </summary>
    public void Add()
    {
        // Int32.Parse(字串) - 將字串轉為整數
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("加法結果：" + (n1 + n2));

        // 輸出結果.文字內容 = 
        result.text = "加法結果：" + (n1 + n2);
    }

    /// <summary>
    /// 減法
    /// </summary>
    public void Substract()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("減法結果：" + (n1 - n2));

        result.text = "減法結果：" + (n1 - n2);
    }

    /// <summary>
    /// 乘法
    /// </summary>
    public void Multiply()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("乘法結果：" + (n1 * n2));

        result.text = "乘法結果：" + (n1 * n2);
    }

    /// <summary>
    /// 除法
    /// </summary>
    public void Divide()
    {
        float n1 = Int32.Parse(number1);
        float n2 = Int32.Parse(number2);

        print("除法結果：" + (n1 / n2));

        result.text = "除法結果：" + (n1 / n2);
    }

    /// <summary>
    /// 餘數
    /// </summary>
    public void Remainder()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("餘數結果：" + (n1 % n2));

        result.text = "餘數結果：" + (n1 % n2);
    }
}

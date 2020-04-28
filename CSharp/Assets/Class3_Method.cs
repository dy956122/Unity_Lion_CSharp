using UnityEngine;

public class Class3_Method : MonoBehaviour
{
    // prefab 預製物
    //儲存帶有 Person 類別的物件
    public Person person1;
    public Person person2;
    public Person person3;

    private void Start()
    {
        //呼叫 person1 方法 Talk
        person1.Talk();
        person2.Talk();
        person3.Talk();

        //傳回方法可以直接當作傳回類型使用
        print("屁孩 BMI:" + person1.BMI() );
        print("警察 BMI:" + person3.BMI() );
        //使用有參數的方法，必須填入相對應的引數
        // 使用選填式參數[選填式參數名稱：值]
        person1.Walk(99, sound: "嘎嘎嘎");
        person2.Walk(100);
        person3.Walk(500, "左邊");

        person1.Attack();
        person2.Attack("球棒");
        person3.Attack("沙漠之鷹");

    }
}

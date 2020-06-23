using UnityEngine;

public struct Direction // 結構不需要做繼承，因此刪掉mono...，接著把class 改成 struct
{
    // 結構與類別的差異 1
    // 結構的欄位不能給予預設值

    /// <summary>
    /// 方向：1 前，2 後，3左，4右 
    /// </summary>
    public int direction;

    // 可以添加修飾詞 const 常數，就可以給予值
    // const 常數： 不能變更的值
    public const int forward = 1;
    public const int back = 2;
    public const int left = 3;
    public const int right = 4;


    /// <summary>
    ///  設定方向：1 前，2後，3左，4右
    /// </summary>
    /// <param name="direction">前、後、左、右</param>
    public void Set(string direction)
    {
        switch (direction)
        {
            case "前":
                this.direction = 1;
                break;
            case "後":
                this.direction = 2;
                break;
            case "左":
                this.direction = 3;
                break;
            case "右":
                this.direction = 4;
                break;
        }
    }


    // 建構子：名稱與結構相同並且沒有傳回類型的方法
    // 作用： 在新稱物件時會自動執行此方法
    // 結構與類別的差異 2
    // 結構的建構子需要有參數
    public Direction(int dir)
    {
        direction = dir;
    }
}
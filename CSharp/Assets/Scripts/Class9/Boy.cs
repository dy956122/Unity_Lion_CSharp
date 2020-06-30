using UnityEngine;

namespace KID.Class9
{
    public class Boy : MonoBehaviour
    {   
        // 發行者：發行事件
        // 1.
        // 定義委派
        // 簽名：無回傳、零參數 無類型
        public delegate void DelegateBoy();

        // 2.
        // 定義事件欄位
        // 修飾詞 事件 委派類型 事件名稱
        // 習慣會用 on 命名
        public event DelegateBoy onNoMoney;

        public int money = 1000;

        private void Update()
        {
            money -= 1;

            if (money == 0)
            {
                print("阿母，我沒錢惹～");
                onNoMoney();                        // 3. 引發事件
            }
        }
    }
}

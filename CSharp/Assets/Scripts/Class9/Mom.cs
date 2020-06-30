using UnityEngine;

namespace KID.Class9
{
    public class Mom : MonoBehaviour
    {
        // 訂閱者：訂閱事件
        public Boy boy;

        void Start()
        {
            // 1.訂閱事件
            boy.onNoMoney += GiveMoney; ; //在打完boy.onNoMoney，並且再打 += 後，再按 Tab 一下，會出現事件
        }

        // 2. 實作方法
        private void GiveMoney()
        {
            // throw new System.NotImplementedException(); 此段會有錯誤，必刪
            print("這麼快就花完啦!!!");
            boy.money += 1000;
        }
    }
}

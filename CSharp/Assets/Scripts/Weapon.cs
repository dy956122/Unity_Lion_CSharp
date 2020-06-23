using UnityEngine;

namespace KID.Class8
{
    public class Weapon : MonoBehaviour,ICanUse
    {
        public Data data;

        public void Use()
        {
            print("裝備武器：" + data.name);

            transform.localScale *= FindObjectOfType<Player>().transform.localScale.x; // 讓玩家手上的道具，依據玩家角色現在比例縮放
            transform.SetParent(FindObjectOfType<Player>().hand);                      // 設定父物件(玩家.手)
            transform.localEulerAngles = new Vector3(0, 0, 45);                        // 旋轉角度
            transform.localPosition = Vector3.zero;                                    // 區域座標 = 零
            GetComponent<Collider>().enabled = false;                                  // 關閉碰撞
        }
    }
}
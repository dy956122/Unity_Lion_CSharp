using UnityEngine;
using UnityEngine.AI;

// 命名空間，避免其他腳本因為撞名而發生錯誤
namespace KID.Class8
{
    public class Player : MonoBehaviour
    {
        public Transform hand;

        private void OnTriggerEnter(Collider other)
        {
            // 不使用介面 的寫法， 東西太多、名字太長，會難以維護
            // if (other.name == "道具" || other.name == "武器") Hit(other.GetComponent < ICanUse>());

            // 使用介面的寫法
            if (other.GetComponent<ICanUse>() != null) Hit(other.GetComponent<ICanUse>()); 
        }

        private void Hit(ICanUse use)
        {
            print("碰到東西~!");
            use.Use();
        }
    }
}

/*namespace Test
{
    public class Player : MonoBehaviour
    {

    }
}*/


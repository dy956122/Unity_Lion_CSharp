using KID.Class9;

using UnityEngine;

namespace Kid.Class9
{
    public class Dad : MonoBehaviour
    {
        public Boy boy;
        void Start()
        {
            boy.onNoMoney += HitBoy;
            boy.onNoMoney += GiveMonry;
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void GiveMonry()
        {
            boy.money += 10;
            print("給你十塊啦 =3=");
        }

        private void HitBoy()
        {
            print("死小孩，欠揍喔!");
        }
    }
}

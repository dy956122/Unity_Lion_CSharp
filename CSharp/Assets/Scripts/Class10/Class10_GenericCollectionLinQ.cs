using UnityEngine;
//using UnityEngine.UI; 此段為自己補充，依照上方的數值類型推斷，那麼其他Unity內建的物件照理來說也可以使用泛型

namespace KID.Class10
{
    public class Class10_GenericCollectionLinQ : MonoBehaviour
    {
        public CharacterFloat cF = new CharacterFloat(100.5f, 50.9f, 10.3f); // 角色浮點數
        public CharacterInt cI = new CharacterInt(100, 50, 15);   // 角色整數

        public Character<float> c1 = new Character<float>(99.9f, 99.9f, 99.9f); // 使用泛型：給予浮點數
        public Character<int> c2 = new Character<int>(50,50,50); // 使用泛型：給予整數
        public Character<long> c3 = new Character<long>(10000,10000,10000); // 使用泛型：給予長整數

        // public Character<Image> I;  此段為自己補充，依照上方的數值類型推斷，那麼其他Unity內建的物件照理來說也可以使用泛型
    }

    #region 不使用泛型
    // 不使用泛型
    // 假設系統需要角色類別：
    // 1. 浮點數欄位 - 血量、經驗值、魔力、攻擊力
    // 2. 整數欄位 - 血量、經驗值、魔力、攻擊力
    public class CharacterFloat
    {
        public float hp;
        public float mp;
        public float exp;
        public float atk;

        public CharacterFloat(float h, float m, float a)
        {
            hp = h; mp = m; atk = a;
        }

        /* public void SetHp(float h)
        {
            hp = h;
        }*/
    }


    public class CharacterInt
    {
        // 快捷鍵：多個游標：Alt + Shift + > (連續多按幾下) ，讓下方被選到的重複字詞，同時被更名
        public int hp;
        public int mp;
        public int exp;
        public int atk;

        // 建構子：跟類別名稱相同並無傳回的方法 - 在新增物件時執行
        public CharacterInt(int h, int m, int a)
        {
            hp = h; mp = m; atk = a;
        }
    }

    // 我想多一個長整數 long
    public class Characterlong
    {
        public long hp;
        public long mp;
        public long exp;
        public long atk;

        public Characterlong(long h, long m, long a)
        {
            hp = h; mp = m; atk = a;
        }
    }

    #endregion 不使用泛型 結束

    // 使用泛型 T 泛型
    public class Character<T>
    {
        public T hp;                // 欄位的類型為泛型
        public T mp;
        public T exp;
        public T atk;
        public Character(T h, T m, T a)
        {
            hp = h; mp = m; atk = a;
        }


        /*public void SetHp(T h) // 此段為老師補充：泛型 比 陣列 可多出一個方法可載入(可看看2020年6月30日的手抄筆記第一頁)
        {
            hp = h;
        }*/
    }

}

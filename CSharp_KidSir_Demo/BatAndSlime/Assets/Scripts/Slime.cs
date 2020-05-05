using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    [Header("顯示訊息")]
    public Text message;
    [Header("蝙蝠")]
    public Bat bat;

    private float hp = 200;
    private float atk = 20;
    private float cure = 10;


    /// <summary>
    /// 攻擊
    /// </summary>
    public void Attack()
    {
        // 呼叫 蝙蝠 受傷方法(史萊姆攻擊力)
        bat.Damage(atk);
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage"></param>
    public void Damage(float damage)
    {
        hp -= damage; // hp = hp - damage;
        message.text = "<b><color=#A0AC15>" + gameObject.name + "</color></b> - 受到傷害：" + damage;
        message.text += "\n<b><color=#A0AC15>" + gameObject.name + "</color></b> - 血量剩下：" + hp;
    }

    /// <summary>
    /// 治癒
    /// </summary>
    public void Cure()
    {
        hp += cure;
        message.text = "<b><color=#A0AC15>" + gameObject.name + "</color></b> - 受到治癒：" + cure;
        message.text += "\n<b><color=#A0AC15>" + gameObject.name + "</color></b> - 血量剩下：" + hp;
    }
}

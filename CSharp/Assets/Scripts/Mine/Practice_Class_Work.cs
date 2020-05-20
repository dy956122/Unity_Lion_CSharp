using UnityEngine;
using UnityEngine.UI;

public class Practice_Class_Work : MonoBehaviour // 總區域
{
    public Time playTime;

    public SpriteRenderer KID;

    public float Score = 1.23456f;

    public GameObject Ball;

    // Start is called before the first frame update
    void Start() //Start 開始
    {
        Time.timeScale = 2f;

        KID.flipX = true;

        print("去除小數點以後：" + Mathf.Floor(Score));


    } //Start 結束

} // 總區域

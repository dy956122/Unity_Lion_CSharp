﻿using UnityEngine;
using UnityEngine.EventSystems; // 引用 事件 API - 拖拉介面

// 實作介面後，也要實作介面所有成員
// 按下 IBeginDragHandler 後會出現紅字，再按下滑鼠右鍵會有一燈泡，按下後選擇 實作介面
// 常常用於 卡牌遊戲
public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, ISkill
{
    private Vector3 pos;

    public void OnBeginDrag(PointerEventData eventData)
    {
        print("開始拖拉了~");
        pos = transform.position;                           // 紀錄原始座標
        // throw new System.NotImplementedException();      // 拋出一例外，表示沒有寫，此段必須刪除
    }

    public void OnDrag(PointerEventData eventData)
    {
        print("拖拉中...");
        transform.position = eventData.position;            // 座標 = 拖拉事件.座標
        //throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)

    {
        print("拖拉結束!");
        transform.position = pos;                           // 回到原始座標

        //throw new System.NotImplementedException();
    }

    public void SkillEffect()
    {
        print("技能特效~");
        //throw new System.NotImplementedException();
    }
}
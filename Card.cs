using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName ="Card")]
public class Card : ScriptableObject {

    public new string name; // 카드 이름
    public string num; // 카드 번호
    public string cardcolor; // 카드 색
    public Sprite artworkF; // 카드 앞면
    public Sprite artworkB; // 카드 뒷면
    public bool isHeart; // 선호카드 판별
    public bool isPick; // 뽑은 카드 true , 안뽑 false
    public float CardPase = 0; // 0은 초기 // 1은 등장 1번 //2는 재선택 때 // 중복 카드 방지, 재선택 용
}

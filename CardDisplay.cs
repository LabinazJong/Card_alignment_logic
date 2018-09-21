using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour {

    public Card card;

    public TextMeshPro m_nameText;

    public Text nameText;
    public Text numText;
    public Text colorText;

    public SpriteRenderer artworkImageF;
    public SpriteRenderer artworkImageB;
    public GameObject heart;

	void Start () {
       
    }

    void Update()
    {
        m_nameText.text = card.name;
        numText.text = card.num;
        colorText.text = card.cardcolor;

        artworkImageF.sprite = card.artworkF;
        artworkImageB.sprite = card.artworkB;

        if (card.isHeart)
        {
            heart.SetActive(true);
        }
        else
        {
            heart.SetActive(false); 
        }
    }
}

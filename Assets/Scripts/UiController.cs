using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour {

    public GameObject CardInfoPanel;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    public void SetCardInfo()
    {
        CardInfo card = new CardInfo("Bukakke", CardType.Universal, 99, "It`s my first card!");
        //CardInfoPanel.transform.GetComponentInChildren<Image>().sprite = Sprite.Create(card.Sprite, new Rect(), Vector3.zero);
        CardInfoPanel.transform.FindChild("Card Name").GetComponent<Text>().text = card.Name;
        CardInfoPanel.transform.FindChild("Card Power").GetComponent<Text>().text = card.Power.ToString();
        CardInfoPanel.transform.FindChild("Card Description").GetComponent<Text>().text = card.Description;
        CardInfoPanel.GetComponent<Animator>().SetTrigger("touched");
    }
}

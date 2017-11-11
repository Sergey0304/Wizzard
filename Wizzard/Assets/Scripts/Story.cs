using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour {

	enum States 
	{
		kidnap,
		death,
		totrture,
		bedEnd,
		goodEnd
	}
	States stete = States.kidnap;
	public Text maniText;

	// Update is called once per frame
	void Kidnap () {
		maniText.text = "тебя схватили и закинули в багажник\n" +
		"(П)Попытаться сбежать\n (Н)Ничего не делать";
		if (Input.GetKeyDown(KeyCode.Y)) {
			stete = States.death;
		}
		if (Input.GetKeyDown(KeyCode.G)) {
			stete = States.totrture;
		}

	}
	void Death () {
		maniText.text = "Вы попытались сбежать вас убили.Конец\n"+"(З)Заново\n.";
		if (Input.GetKeyDown(KeyCode.P)) 
			{
			stete = States.kidnap;
		}

	}
	void Update() {
		if (stete == States.death) {
			Death ();
		}
		if(stete == States.kidnap) {
			Kidnap ();
		}
}
}
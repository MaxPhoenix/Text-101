using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    //SerializeField is to make it avaiable within the Unity's inspector for changes to be made on this field
    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] State startingState;
    State currentState;

    //obtain the image component attached to the "background" game object
    Image backgroundImage;
    //obtain the button components attached to the "options" game objects
    Button option1;
    Button option2;

    // Use this for initialization
    void Start() {

        this.backgroundImage = GameObject.Find("Canvas/Main BackGround").GetComponent<Image>();
        this.option1 = GameObject.Find("Canvas/Option 1").GetComponent<Button>();
        this.option2 = GameObject.Find("Canvas/Option 2").GetComponent<Button>();
        this.currentState = this.startingState;
        this.textComponent.text = this.currentState.GetStateStory();
        this.backgroundImage.sprite = this.currentState.GetSceneImage();

        //adding listeners to click events
        this.option1.onClick.AddListener(() => ManageState(option1.name));
        this.option2.onClick.AddListener(() => ManageState(option2.name));
    }
	
	// Update is called once per frame
	void Update () {
        //this.ManageState();
	}

    private void ManageState(String buttonName){
        //var: shortcut way of typing data type when we declare and initialize a variable at the same time
        var nextStates = this.currentState.GetNextStages();
        //old keyboard input options
        /*
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            this.currentState = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)){
            this.currentState = nextStates[1];
        }
        else {
            
        }
        */

        //manejo de botones
        if (buttonName.Equals(this.option1.name)){
            this.currentState = nextStates[0];
        }
        else if (buttonName.Equals(this.option2.name)){
            this.currentState = nextStates[1];
        }

        this.textComponent.text = this.currentState.GetStateStory();
        this.backgroundImage.sprite = this.currentState.GetSceneImage();
    }
}

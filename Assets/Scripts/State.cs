using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Changing the extension of the class from MonoBehavior in order to tell unity is a scriptableObject
//"CreateAssetMenu" makes it possible to create an instance of this asset from the editor
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

    /*first number: min size in the inspector to write 
      second number: amount of lines before starting scrollin
    */
    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    [SerializeField] Sprite sceneImage;

    public string GetStateStory(){
        return this.storyText;
    }

    public State[] GetNextStages(){
        return this.nextStates;
    }

    public Sprite GetSceneImage(){
        return this.sceneImage;
    }
}

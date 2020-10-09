using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "State", menuName = "Text 101/State", order = 0)]
public class State : ScriptableObject {
   [TextArea(14,10)] [SerializeField] string storyText;
  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="State")]
public class State : ScriptableObject
{
	// Start is called before the first frame update
	[TextArea(10,14)][SerializeField] string storyText;

	[SerializeField] State[] nextState;

	public string GetStatesStory()
	{
		return storyText;
	}

	public State[] GetNextStates()
	{
		return nextState;   
	}  
}

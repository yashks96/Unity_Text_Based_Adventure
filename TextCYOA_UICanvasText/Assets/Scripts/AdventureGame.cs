using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Start is called before the first frame update
	//[SerializeField] Text textComponent;
	[SerializeField] State startingState;
	TextMeshProUGUI textComponent2;

	State state;
	void Start()
    {
		state = startingState;
		//textComponent.text = state.GetStatesStory();
		textComponent2 = GetComponent<TextMeshProUGUI>();
		textComponent2.text = state.GetStatesStory();
    }

    // Update is called once per frame
    void Update()
    {
		int checkCode = ManageStates();
		//textComponent.text = state.GetStatesStory();
		if (checkCode == 0)
		{
			textComponent2 = GetComponent<TextMeshProUGUI>();
			textComponent2.text = state.GetStatesStory();
		}
		else if (checkCode == 1)
		{
			Debug.Log("CheckCode"+checkCode);
			Application.Quit(0);
		}
	}

	private int ManageStates()
	{
		var possibleNextStates = state.GetNextStates();
		Debug.Log("No of next States "+possibleNextStates.Length);
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			state = possibleNextStates[0];
			return 0;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			if (possibleNextStates.Length == 1)
			{
				Application.Quit();
			}
			else
			{
				state = possibleNextStates[1];
				return 0;
			}
		}
		return 0;
	}
}

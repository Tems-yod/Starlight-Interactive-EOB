using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
	[SerializeField] private Animator doorAnim = null;

	private bool doorOpen = true;

	[SerializeField] private string openAnimationName = "DoorOpen";
	[SerializeField] private string closeAnimationName = "DoorClose";

	[SerializeField] private int waitTimer = 1;
	[SerializeField] private bool pauseInteraction = false;

	[SerializeField] private bool isLocked = false;
	
	AudioSource DoorSound;


	void Start()
    {
        DoorSound = GetComponent<AudioSource>();
		PlayAnimation();
    }

	private IEnumerator PauseDoorInteraction()
	{
		pauseInteraction = true;
		yield return new WaitForSeconds(waitTimer);
		pauseInteraction = false;
	}

	public void PlayAnimation()
	{
		
		if(!doorOpen && !pauseInteraction)
		{
			if(!isLocked)
			{
				Debug.Log("Door Opening");
				doorAnim.Play(openAnimationName, 0, 0.0f);
				DoorSound.Play(0);
				doorOpen = true;
			}
			else
			{
			
			}
			StartCoroutine(PauseDoorInteraction());
		}
		else if(doorOpen && !pauseInteraction)
		{
			Debug.Log("Door Closing");
			doorAnim.Play(closeAnimationName, 0, 0.0f);
			DoorSound.Play(0);
			doorOpen = false;
			StartCoroutine(PauseDoorInteraction());
		}
	}
}

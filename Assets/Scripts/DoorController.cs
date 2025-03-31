using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
	[SerializeField] private Animator doorAnim = null;

	private bool doorOpen = false;

	[SerializeField] private string openAnimationName = "DoorAnimation";
	[SerializeField] private string closeAnimationName = "DoorClose";

	[SerializeField] private int waitTimer = 1;
	[SerializeField] private bool pauseInteraction = false;

	
	AudioSource DoorSound;

	void Start()
    {
        DoorSound = GetComponent<AudioSource>();
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
			doorAnim.Play(openAnimationName, 0, 0.0f);
			DoorSound.Play(0);
			doorOpen = true;
			StartCoroutine(PauseDoorInteraction());
		}
		else if(doorOpen && !pauseInteraction)
		{
			doorAnim.Play(closeAnimationName, 0, 0.0f);
			DoorSound.Play(0);
			doorOpen = false;
			StartCoroutine(PauseDoorInteraction());
		}
	}
}

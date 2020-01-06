using UnityEngine;

public class RateMore : MonoBehaviour
{

	public void Rate ()
	{
		// "market" works for android  (iOS: put your app link
		Application.OpenURL ("market://details?id=com.test.testtest");
	}

	public void More ()
	{
		// Android  ,(iOS: put you app store link)
		Application.OpenURL ("https://play.google.com/store/apps/dev?id=1551996653619230352");
	}

	public void Feedback ()
	{
		Application.OpenURL ("mailto:youremail@gmail.com");
	}
}

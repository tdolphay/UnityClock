using System;
using UnityEngine;

public class ChangeValue : MonoBehaviour {
	public TextMesh hour, minute;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DateTime time = DateTime.Now;

		int hourValue = time.Hour;
		int minuteValue = time.Minute;

		if (hourValue >= 0 && hourValue <= 9) {
			hour.text = "0" + hourValue.ToString();
		} else {
			hour.text = hourValue.ToString();
		}

		if (minuteValue >= 0 && minuteValue <= 9) {
			minute.text = "0" + minuteValue.ToString();
		} else {
			minute.text = minuteValue.ToString();
		}
	}
}

using System;
using UnityEngine;

public class Clock : MonoBehaviour {
	const float degreesPerHour = 30f, degreesPerMinute = 6f, degreesPerSecond = 6f;
	public Transform hoursTransform, minutesTransform, secondsTransform;
	public bool continuous;

	void Awake() {
		

		if (continuous) {
			TimeSpan time = DateTime.Now.TimeOfDay;

			hoursTransform.localRotation = Quaternion.Euler (0f, (float) time.TotalHours * degreesPerHour, 0f);
			minutesTransform.localRotation = Quaternion.Euler (0f, (float) time.TotalMinutes * degreesPerMinute, 0f);
			secondsTransform.localRotation = Quaternion.Euler (0f, (float) time.TotalSeconds * degreesPerSecond, 0f);
		} else {
			DateTime time = DateTime.Now;

			hoursTransform.localRotation = Quaternion.Euler (0f, time.Hour * degreesPerHour, 0f); // Rotation storage. Multiply hour by 30 to get correct rotation around center
			minutesTransform.localRotation = Quaternion.Euler (0f, time.Minute * degreesPerMinute, 0f);
			secondsTransform.localRotation = Quaternion.Euler (0f, time.Second * degreesPerSecond, 0f);
		}
	}

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		Awake();
	}
}
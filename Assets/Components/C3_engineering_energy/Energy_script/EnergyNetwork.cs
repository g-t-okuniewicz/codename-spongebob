using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnergyNetwork : MonoBehaviour 
{
	private float batteryFull;
	private int batteryDuration;

	//-----------------------------
	public int GetTotalSeconds()
	{
		return batteryDuration;
	}

	//-----------------------------
	public void Resetbattery(int seconds)
	{
		batteryFull = Time.time;
		batteryDuration = seconds;
	}

	//-----------------------------
	public int GetSecondsRemaining()
	{
		int elapsedSeconds = (int)(Time.time - batteryFull);
		int secondsLeft = (BatteryDuration - elapsedSeconds);
		return secondsLeft;
	}

	//-----------------------------
	public float GetProportionTimeRemaining()
	{
		float proportionLeft = (float)GetSecondsRemaining() / (float)GetTotalSeconds();
		return proportionLeft;
	}
}

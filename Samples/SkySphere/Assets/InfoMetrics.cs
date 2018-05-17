using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class InfoMetrics : MonoBehaviour {

	public int FPS { get; private set; }
	public Text text;
	// Use this for initialization


	public float updateInterval = 0.1f;
	private float accum = 0.0f; // FPS accumulated over the interval
	private float frames = 0f; // Frames drawn over the interval
	private float timeleft = 0.5f; // Left time for current interval
	
	public PerformanceCounter diskCounter;
	private PerformanceCounter cpuCounter;
	private PerformanceCounter ramCounter;

	void Start()
	{
		if( !text )
		{
			print ("FramesPerSecond needs a text component!");
			enabled = false;
			return;
		}
		timeleft = updateInterval;  

		cpuCounter = new PerformanceCounter("Processor", "% Processor Time");
		diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
		ramCounter = new PerformanceCounter("Memory", "Available MBytes");
	}
		
	public float getCurrentCpuUsage(){
		return cpuCounter.NextValue();
	}

	public float getAvailableRAM(){
		return ramCounter.NextValue();
	}

	public float getDisk(){
		return diskCounter.NextValue();
	}
	
	void Update()
	{
		timeleft -= Time.deltaTime;
		accum += Time.timeScale/Time.deltaTime;
		++frames;
	
		// Interval ended - update GUI text and start new interval
		if( timeleft <= 0.0f )
		{
			// display two fractional digits (f2 format)
			text.text = "FPS: " + (accum/frames).ToString("f2");
			// text.text += "\nCPU usage: " + getCurrentCpuUsage().ToString("f2") + "%";
			// text.text += "\nAvailable memory: " + getAvailableRAM().ToString("f2") + "MB";
			// text.text += "\nDisk usage: " + getDisk().ToString("f2");
			
		
			timeleft = updateInterval;
			accum = 0.0f;
			frames = 0f;
		}
	}


	// Update is called once per frame
	// void Update () {

	// }
}

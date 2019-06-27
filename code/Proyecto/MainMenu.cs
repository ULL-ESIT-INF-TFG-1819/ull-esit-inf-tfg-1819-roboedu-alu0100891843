using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UBlockly.UGUI;
using UBlockly;
using UBlocklyGame.Robot;
public class MainMenu : MonoBehaviour {

	public void CreateRobotSq () {
		CSharp.Interpreter.Stop(); 
		SceneManager.LoadScene ("CreationSq");
	}

	public void SimulateIR() {
		SceneManager.LoadScene ("Simulator - IR");
	}
	public void SimulateUS() {
		SceneManager.LoadScene ("Simulator - US");
	}
	public void SimulateTouch() {
		SceneManager.LoadScene ("Simulator - Touch");
	}

	public void Back(){
		SceneManager.LoadScene ("Menu_S");
	}

	public void Quit() {
		Application.Quit ();
	}
}

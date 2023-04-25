using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	public bool isLightDay = false;
    public bool isMusicAspirationWoods = false;
    public bool isLevelNature = false;
    public bool UIFinished = false;

    // Start is called before the first frame update
    void Start()
    {
		// reset the UI when the levels go back to starting scene
		UIFinished = false;

	}

	public void setIsLightDay()
	{
		isLightDay = true;
	}

	public void setIsMusicAspirationWoods()
	{
		isMusicAspirationWoods = true;
	}

	public void setIsLevelNature()
	{
		isLevelNature = true;
	}

	public void setUIFinished()
	{
		UIFinished = true;
	}

	// Update is called once per frame
	void Update()
    {
        if (UIFinished == true)
        {
            if (isLightDay == true) // DAY
            {
                if(isMusicAspirationWoods == true) // music is Aspiration Woods
                {
                    if(isLevelNature == true) // level is nature
                    {
						Debug.Log("Nature_Day_AspirationWoods");
						SceneManager.LoadScene("Nature_Day_AspirationWoods");
					}
                    else // level is docks
                    {
						Debug.Log("Dock_Day_AspirationWoods");
						SceneManager.LoadScene("Dock_Day_AspirationWoods");
					}
                }
				else // music is Lost Kingdom
				{
					if (isLevelNature == true) // level is nature
					{
						Debug.Log("Nature_Day_LostKingdom");
						SceneManager.LoadScene("Nature_Day_LostKingdom");
					}
					else // level is docks
					{
						Debug.Log("Dock_Day_LostKingdom");
						SceneManager.LoadScene("Dock_Day_LostKingdom");
					}
				}
            }
            else                    // NIGHT
            {
				if (isMusicAspirationWoods == true) // music is Aspiration Woods
				{
					if (isLevelNature == true) // level is nature
					{
						Debug.Log("Nature_Night_AspirationWoods");
						SceneManager.LoadScene("Nature_Night_AspirationWoods");
					}
					else // level is docks
					{
						Debug.Log("Dock_Night_AspirationWoods");
						SceneManager.LoadScene("Dock_Night_AspirationWoods");
					}
				}
				else // music is Lost Kingdom
				{
					if (isLevelNature == true) // level is nature
					{
						Debug.Log("Nature_Night_LostKingdom");
						SceneManager.LoadScene("Nature_Night_LostKingdom");
					}
					else // level is docks
					{
						Debug.Log("Dock_Night_LostKingdom");
						SceneManager.LoadScene("Dock_Night_LostKingdom");
					}
				}
			}
        }
    }
}

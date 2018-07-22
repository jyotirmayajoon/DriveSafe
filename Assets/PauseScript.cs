using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseScript : MonoBehaviour {
    public Transform canvas,canvas1;
    public Image image1,image2,image3,image4;
    void Update()
    {
        Debug.Log(1.0f / Time.deltaTime);
        if(Time.timeSinceLevelLoad>=35f && SceneManager.GetActiveScene().buildIndex != 4)
        {

            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
               
                Time.timeScale = 0;
            }
        }
        else if(Time.timeSinceLevelLoad >= 22f && SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
             
                Time.timeScale = 0;
            }
        }
    }
    void OnGUI()
    {

        if( (Time.timeSinceLevelLoad <= 22f && SceneManager.GetActiveScene().buildIndex == 4) || (Time.timeSinceLevelLoad <= 35f && SceneManager.GetActiveScene().buildIndex != 4))
        if (GUI.Button(new Rect(130, 100, 100, 40), "Pause"))
        {
            canvas1.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

public void quit()
    {
        SceneManager.LoadScene(0);
    }
    public void resume()
    {
        Time.timeScale = 1;
    }
    public void restart1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void restart2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }
    public void restart3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }
    public void pause()
    {
        Time.timeScale = 0;
    }
    public void image1display()
    {
        Debug.Log("button clicked");
        image1.enabled = true;
    }
    public void image2display()
    {
        Debug.Log("button clicked");
        image2.enabled = true;
    }
    public void image3display()
    {
        Debug.Log("button clicked");
        image3.enabled = true;
    }
    public void image4display()
    {
        Debug.Log("button clicked");
        image4.enabled = true;
    }
    public void rightanswer()
    {
        StartCoroutine(waiter());
        SceneManager.LoadScene(1);
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(7);
    }
}

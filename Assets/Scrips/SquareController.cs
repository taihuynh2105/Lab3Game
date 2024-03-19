using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SquareController : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 60;
    public Text countdownText;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    IEnumerator Countdown()
    {
        while (timeRemaining > 0)
        {
            yield return new WaitForSeconds(1) ;
            timeRemaining--;
            countdownText.text = "Time: " + timeRemaining.ToString();
        }
        countdownText.text = "Time Over!!";
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement=new Vector3 (horizontal, vertical, 0f).normalized;
        transform.Translate(movement * 3f * Time.deltaTime  );
    }
    public void LoadNextScene()
    {
        int currentSceneIndex= SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Circle"))
        {
            Debug.Log("aloalo");
            Vector2 firstPosition = new Vector2(-9.69f, 0.01f);
            transform.position=firstPosition;
        }
        if (col.gameObject.name.Equals("Box"))
        {
            Debug.Log("YOU WIN");
            LoadNextScene();
            
        }
    }

   
}

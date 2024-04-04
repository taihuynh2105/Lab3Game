using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Pause;
    void Start()
    {
        UnityEngine.UI.Button button = GetComponent<UnityEngine.UI.Button>();
        button.onClick.AddListener(OnClick);
    }
    void OnClick()
    {
        ShowMenu();
    }
    // Update is called once per frame
    public void ShowMenu()
    {
        Pause.SetActive(true);

    }
}

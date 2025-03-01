using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestButton : MonoBehaviour
{
    public int num;
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(()=>ClickButton());
        EventManager.StartListening<int>(EventName.ButtonClicked, OnButtonClicked);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickButton()
    {
        EventManager.TriggerEvent(EventName.ButtonClicked, num);
    }

    void OnButtonClicked(int _num)
    {
        GetComponent<Image>().color = GetColor(_num);
    }

    Color GetColor(int _num)
    {
        switch (_num)
        {
            case 0:
                return Color.white;
            case 1:
                return Color.green;
            case 2:
                return Color.blue;
            case 3:
                return Color.red;
            default: return Color.white;

        }
    }
    private void OnDestroy()
    {
        EventManager.StopListening<int>(EventName.ButtonClicked, OnButtonClicked);
    }
}

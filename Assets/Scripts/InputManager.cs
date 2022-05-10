using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{

    public InputField ifUserName;
    public Text txtUserName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UserGreetings()
    {
        Debug.Log(int.Parse(txtUserName.text) * 2);
    }
}
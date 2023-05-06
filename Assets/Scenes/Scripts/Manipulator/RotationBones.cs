using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationBones : MonoBehaviour
{
    public Slider main;
    public Slider second;
    public Slider third;
    public Slider hand;
    public GameObject mainM;
    public GameObject secondM;
    public GameObject thirdM;
    public GameObject handM;

    void Start()
    {   
        main.value = 0.5f;
        second.value = 0.5f;
        third.value = 0.5f;
        hand.value = 0.5f;
    }

    void FixedUpdate()
    {
        Vector3 mainR = new Vector3(0, (180 / 100) * (main.value * -360), -47);
        mainM.transform.localEulerAngles = mainR;

        Vector3 secondR = new Vector3(1, 0, (180 / 100) * (second.value * 160));
        secondM.transform.localEulerAngles = secondR;

        Vector3 thirdR = new Vector3(0, 0, (180 / 100) * (third.value * -160));
        thirdM.transform.localEulerAngles = thirdR;

        Vector3 handR = new Vector3(0, (360 / 100) * (hand.value * -180), 0);
        handM.transform.localEulerAngles = handR;
    }
}

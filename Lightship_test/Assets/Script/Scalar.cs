using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;
public class Scalar : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider rotationSlider;
    public Slider scaleSlider;

    private float angleSliderNumber;
    private float scaleSliderNumber;

    // Update is called once per frame
    void Update()
    {
        if (Screen.width > Screen.height)
        {
            // Landscape mode
            angleSliderNumber = rotationSlider.value * 10f;
            this.transform.rotation = Quaternion.Euler(0, angleSliderNumber, 0);

            scaleSliderNumber = scaleSlider.value;

            Vector3 scale = new Vector3(scaleSliderNumber, scaleSliderNumber, scaleSliderNumber);
            this.transform.localScale = scale;
        }
        else
        {
            angleSliderNumber = rotationSlider.value * 10f;
            this.transform.rotation = Quaternion.Euler(0, angleSliderNumber, 0);

            scaleSliderNumber = scaleSlider.value;

            Vector3 scale = new Vector3(scaleSliderNumber, scaleSliderNumber, scaleSliderNumber);
            this.transform.localScale = scale;
        }
    }
}

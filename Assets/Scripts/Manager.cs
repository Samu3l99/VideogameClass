using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject uma;
    public Animator umaAnim;

    public void TranslateUp()
    {
        uma.transform.Translate(Vector3.up * Time.deltaTime * 10, Space.Self);
    }

    public void TranslateDown()
    {
        uma.transform.Translate(Vector3.down * Time.deltaTime * 10, Space.Self);
    }
    public void TranslateRight()
    {
        uma.transform.Translate(Vector3.right * Time.deltaTime * 10, Space.Self);
    }
    public void TranslateLeft()
    {
        uma.transform.Translate(Vector3.left * Time.deltaTime * 10, Space.Self);
    }

    public void Scale(float magnitud)
    {
        Vector3 changerScale = new Vector3(magnitud, magnitud, magnitud);
        uma.transform.localScale += changerScale;
    }

    public void RotateRight()
    {
        uma.transform.Rotate(0.0f, -10.0f, 0.0f, Space.Self);
    }

    public void RotateLeft()
    {
        uma.transform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);
    }

    public void PlayAnimation()
    {
        umaAnim.Play("Dance");
    }
}

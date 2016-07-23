using UnityEngine;
using System.Collections;

public class PlayerPress : MonoBehaviour {

    public GameObject column1;
    public GameObject column2;
    public GameObject column3;
    public GameObject column4;

	void Update()
    {
        // AS45
        if(Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.Keypad4) && Input.GetKeyDown(KeyCode.Keypad5))
        {
            column1.transform.Translate(new Vector3(0, -1, 0));
            column2.transform.Translate(new Vector3(0, -1, 0));
            column3.transform.Translate(new Vector3(0, -1, 0));
            column4.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column1));
            StartCoroutine(ResetPosition(column2));
            StartCoroutine(ResetPosition(column3));
            StartCoroutine(ResetPosition(column4));
            return;        
        }
        // AS4
        else if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.Keypad4))
        {
            column1.transform.Translate(new Vector3(0, -1, 0));
            column2.transform.Translate(new Vector3(0, -1, 0));
            column3.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column1));
            StartCoroutine(ResetPosition(column2));
            StartCoroutine(ResetPosition(column3));
            return;
        }
        // AS5
        else if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.Keypad5))
        {
            column1.transform.Translate(new Vector3(0, -1, 0));
            column2.transform.Translate(new Vector3(0, -1, 0));
            column4.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column1));
            StartCoroutine(ResetPosition(column2));
            StartCoroutine(ResetPosition(column4));
            return;
        }

        else if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.Keypad4) && Input.GetKeyDown(KeyCode.Keypad5))
        {
            column1.transform.Translate(new Vector3(0, -1, 0));
            column3.transform.Translate(new Vector3(0, -1, 0));
            column4.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column1));
            StartCoroutine(ResetPosition(column3));
            StartCoroutine(ResetPosition(column4));
            return;
        }

        else if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.Keypad4) && Input.GetKeyDown(KeyCode.Keypad5))
        {
            column2.transform.Translate(new Vector3(0, -1, 0));
            column3.transform.Translate(new Vector3(0, -1, 0));
            column4.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column2));
            StartCoroutine(ResetPosition(column3));
            StartCoroutine(ResetPosition(column4));
            return;
        }

        else if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S))
        {
            column1.transform.Translate(new Vector3(0, -1, 0));
            column2.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column1));
            StartCoroutine(ResetPosition(column2));
            return;
        }

        else if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.Keypad4))
        {
            column1.transform.Translate(new Vector3(0, -1, 0));
            column3.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column1));
            StartCoroutine(ResetPosition(column3));
            return;
        }

        else if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.Keypad5))
        {
            column1.transform.Translate(new Vector3(0, -1, 0));
            column4.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column1));
            StartCoroutine(ResetPosition(column4));
            return;
        }

        else if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.Keypad4))
        {
            column2.transform.Translate(new Vector3(0, -1, 0));
            column3.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column2));
            StartCoroutine(ResetPosition(column3));
            return;
        }

        else if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.Keypad5))
        {
            column2.transform.Translate(new Vector3(0, -1, 0));
            column4.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column2));
            StartCoroutine(ResetPosition(column4));
            return;
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4) && Input.GetKeyDown(KeyCode.Keypad5))
        {
            column3.transform.Translate(new Vector3(0, -1, 0));
            column4.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column3));
            StartCoroutine(ResetPosition(column4));
            return;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            column1.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column1));
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            column2.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column2));
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            column3.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column3));
        }

        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            column4.transform.Translate(new Vector3(0, -1, 0));
            StartCoroutine(ResetPosition(column4));
        }

    }

    IEnumerator ResetPosition(GameObject column)
    {
        yield return new WaitForSeconds(0.05f);
        column.transform.Translate(new Vector3(0, 1, 0));
    }
}

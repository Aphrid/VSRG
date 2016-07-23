using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class NoteSpawner : MonoBehaviour {

    public GameObject note;
    private int bar;

    private bool gameStart;

    public GUIText restartText;

    void Start()
    {
        bar = 0;
        gameStart = false;
        StartCoroutine(SpawnNotes());
        restartText.text = "";

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameStart = true;
        }

        if (bar >= 55)
        {
            restartText.text = "Press 'R' To Restart";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    IEnumerator SpawnNotes()
    {
        yield return new WaitWhile(() => !gameStart);          
        while (true)
        {
            List<int> col = new List<int>();
            switch (bar)
            {
                case 1:
                    col.Add(1);
                    col.Add(2);
                    break;
                case 2:
                    col.Add(2);
                    col.Add(3);
                    col.Add(4);
                    break;
                case 3:
                    col.Add(2);
                    col.Add(4);
                    break;
                case 4:
                    col.Add(1);
                    col.Add(3);
                    col.Add(4);
                    break;
                case 5:
                    col.Add(1);
                    col.Add(3);
                    break;
                case 6:
                    col.Add(1);
                    col.Add(2);
                    col.Add(4);
                    break;
                case 7:
                    col.Add(3);
                    col.Add(4);
                    break;
                case 8:
                    col.Add(2);
                    col.Add(3);
                    col.Add(4);
                    break;
                case 9:
                    col.Add(1);
                    col.Add(2);
                    break;
                case 10:
                    col.Add(1);
                    col.Add(2);
                    col.Add(3);
                    break;
                case 11:
                    col.Add(1);
                    col.Add(4);
                    break;
                case 12:
                    col.Add(1);
                    col.Add(3);
                    col.Add(4);
                    break;
                case 13:
                    col.Add(2);
                    col.Add(3);
                    break;
                case 14:
                    col.Add(1);
                    col.Add(2);
                    col.Add(3);
                    break;
                case 15:
                    col.Add(2);
                    col.Add(4);
                    break;
                case 16:
                    col.Add(2);
                    col.Add(3);
                    col.Add(4);
                    break;
                case 17:
                    col.Add(1);
                    col.Add(2);
                    break;
                case 18:
                    col.Add(1);
                    col.Add(2);
                    col.Add(4);
                    break;
                case 19:
                    col.Add(2);
                    col.Add(4);
                    break;
                case 20:
                    col.Add(1);
                    col.Add(2);
                    col.Add(3);
                    break;
                case 21:
                    col.Add(1);
                    col.Add(3);
                    break;
                case 22:
                    col.Add(2);
                    col.Add(3);
                    col.Add(4);
                    break;
                case 23:
                    col.Add(1);
                    col.Add(2);
                    break;
                case 24:
                    col.Add(1);
                    col.Add(3);
                    col.Add(4);
                    break;
                case 25:
                    col.Add(3);
                    col.Add(4);
                    break;
                case 26:
                    col.Add(1);
                    col.Add(2);
                    col.Add(4);
                    break;
                case 27:
                    col.Add(2);
                    col.Add(4);
                    break;
                case 28:
                    col.Add(2);
                    col.Add(3);
                    col.Add(4);
                    break;
                case 29:
                    col.Add(2);
                    col.Add(3);
                    break;
                case 30:
                    col.Add(1);
                    col.Add(3);
                    col.Add(4);
                    break;
                case 31:
                    col.Add(3);
                    col.Add(4);
                    break;
                case 32:
                    col.Add(2);
                    col.Add(3);
                    col.Add(4);
                    break;
                case 33:
                    col.Add(3);
                    col.Add(4);
                    break;
                case 34:
                    StartCoroutine(fastSection());
                    break;
                case 39:
                    StartCoroutine(pianoSection());
                    break;                
                case 42:
                    StartCoroutine(fastSection());
                    break;
            }
            newNote(col);
            yield return new WaitForSeconds(0.42f);

            bar++;           
        }
    }

    IEnumerator fastSection()
    {
        while (true)
        {
            List<int> col = new List<int>();
            switch (bar)
            {
                case 34:
                    col.Add(1);
                    break;
                case 35:
                    col.Add(2);
                    break;
                case 36:
                    col.Add(3);
                    break;
                case 37:
                    col.Add(4);
                    break;
                case 42:
                    col.Add(2);
                    break;
                case 43:
                    col.Add(3);
                    break;
                case 44:
                    col.Add(4);
                    break;
            }
            newNote(col);
            yield return new WaitForSeconds(0.117f);
            bar++;

            if(bar == 38 || bar == 45)
            {
                yield return new WaitForSeconds(0.117f * 3);
                break;
            }
        }
    }

    IEnumerator pianoSection()
    {
        while (true)
        {
            List<int> col = new List<int>();
            switch (bar)
            {
                case 39:
                    col.Add(2);
                    col.Add(3);
                    break;
                case 40:
                    col.Add(2);
                    col.Add(3);
                    break;
            }
            newNote(col);
            yield return new WaitForSeconds(0.234f);
            bar++;

            if (bar == 41)
            {
                yield return new WaitForSeconds(0.234f);
                break;
            }
        }
    }

    private void newNote(List<int> col)
    {
        Vector3 offset;

        for(int i = 0; i < col.Count; i++)
        {
            offset = GetLoc(col[i]);
            Instantiate(note, transform.position + offset, transform.rotation);
        } 
    }

    private Vector3 GetLoc(int location)
    {
        Vector3 offset;
        if (location == 2)
        {
            offset = new Vector3(3.0f, 0.0f, 0.0f);
        }
        else if (location == 3)
        {
            offset = new Vector3(6.0f, 0.0f, 0.0f);
        }
        else if (location == 4)
        {
            offset = new Vector3(9.0f, 0.0f, 0.0f);
        }
        else
        {
            offset = new Vector3();
        }

        return offset;
    }
}

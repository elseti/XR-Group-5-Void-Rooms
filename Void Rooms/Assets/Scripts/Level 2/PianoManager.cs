 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoManager : Singleton<PianoManager>
{
    public string[] correctSequence;
    public GameObject magicCircle;
    private int currIndex = 0;
    private bool isSolved = false;
    
    // Start is called before the first frame update
    void Start()
    {
        // Make sure they're all lower case
        for (int x = 0; x < correctSequence.Length-1; x++)
        {
            correctSequence[x] = correctSequence[x].ToLower();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Check if sequence is correct
    public void PressNote(string s)
    {
        s = s.ToLower();
        if (!isSolved)
        {
            if (correctSequence[currIndex] == s)
            {
                currIndex++;
                if (currIndex == correctSequence.Length)
                {
                    print("piano is solved!");
                    isSolved = true;
                    GameManager.instance.portalOpened.Invoke();
                    magicCircle.SetActive(true);
                }
            }
            else
            {
                currIndex = 0;
            }
        }
        
    }
}

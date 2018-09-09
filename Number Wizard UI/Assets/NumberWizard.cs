using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    int min;
    int max;
    int guess;

    public int maxGuessesAllowed = 5;
    public Text text;

    /// <summary>
    /// Start the game
    /// </summary>
	void Start (){
        StartGame();
	}

    /// <summary>
    /// Set variables and call first guess
    /// </summary>
    void StartGame(){
        max = 1000;
        min = 1;
        NextGuess();
    }

    /// <summary>
    /// Make a lower guess
    /// </summary>
    public void GuessLower(){
        max = guess;
        NextGuess();
    }

    /// <summary>
    /// Make a higher guess
    /// </summary>
    public void GuessHigher(){
        min = guess;
        NextGuess();
    }

    /// <summary>
    /// Guess the mext number
    /// </summary>
    void NextGuess(){
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString(); ;
        maxGuessesAllowed = maxGuessesAllowed - 1;

        // if the number of guess becomes less than or equal to zero
        if (maxGuessesAllowed <= 0){
            SceneManager.LoadScene("Win");
        }
    }
}

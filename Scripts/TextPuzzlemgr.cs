using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class TextPuzzlemgr : MonoBehaviour {
	public GameObject textPuzzle;  // this define the pickable object
	public PlayerMovement Player;
	public bool isActive;
	public bool stopPlayerMovement;
	//end of enabling and disabling the pickable
	public Question[] questions;
	private static List<Question> unansweredQuestion;
	private Question currentQuestion;
	[SerializeField]
		private Text statementText;
	[SerializeField]
	private Text trueAnswerText;
	[SerializeField]
	private Text falseAnswerText;
	[SerializeField]
	private float timeBetweenQuestions = 2f;
	[SerializeField]
	private Animator animator;
	// Use this for initialization
	void Start () {
	   
		if (unansweredQuestion==null ||unansweredQuestion.Count==0)
		{
			unansweredQuestion = questions.ToList<Question>();
		}

		SetCurrentQuestion();

	}

	void SetCurrentQuestion()
	{
		int randomQuestionIndex = Random.Range(0,unansweredQuestion.Count);
		currentQuestion = unansweredQuestion[randomQuestionIndex];

		statementText.text = currentQuestion.statement;

		unansweredQuestion.RemoveAt(randomQuestionIndex);
		if (currentQuestion.isTrue)
		{
			trueAnswerText.text = "AWESOME";
			falseAnswerText.text = "Nice Try, Wrong!";
		}
		else
		{
			trueAnswerText.text = "Nice Try, Wrong!";
			falseAnswerText.text = "AWESOME";
		}

	}
	IEnumerator TransitionToNewQuestion()
	{

		//ADD MORE CODE TO LOOP THROUGH QUESTIONS
		unansweredQuestion.Remove(currentQuestion);
		yield return new WaitForSeconds(timeBetweenQuestions);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		//Application.LoadLevel();
		
	}
	public void selectCorrect()
	{
		animator.SetTrigger("True");
		if (currentQuestion.isTrue)
		{
			Debug.Log("AWESOME");
		}
		else
		{
			Debug.Log("Nice Try, Incorect");
		}
		StartCoroutine(TransitionToNewQuestion());
	}
	public void selectWrong()
	{
		animator.SetTrigger("False");
		if (!currentQuestion.isTrue)
		{
			Debug.Log("AWESOME");
		}
		else
		{
			Debug.Log("Nice Try, Incorect");
		}
		StartCoroutine(TransitionToNewQuestion());
	}
	//Methods to enable and disable the textpuzzle in the scene
	public void EnablePuzzle()
	{
		textPuzzle.SetActive(true);
		isActive = true;
		if (stopPlayerMovement)
		{
			Player.canMove = false;
		}
	}
	public void DisablePuzzle()
	{
		textPuzzle.SetActive(false);
		Player.canMove = true;
		isActive = false;
	}

}

using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
public class GameManger : MonoBehaviour
{
    public float timeRemaining = 60f; 
    public TextMeshProUGUI timerText;

    public int score = 0; 
    public TextMeshProUGUI scoreText;

    public GameObject Player;
    public Vector3 newPosition = new Vector3(1, 0.2f, 1);

    public GameObject[] points;
    private GameObject[] allObjects;

    

    public GameObject auraPrefab;
    public Transform characterTransform;
    private GameObject currentAuraInstance;
    private Movement movementScript;

    private void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        allObjects = GameObject.FindObjectsOfType<GameObject>();
        
        if (Player != null)
        {
            movementScript = Player.GetComponent<Movement>();
        }
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; 
            UpdateTimerDisplay();
        }
        else
        {
            TimeIsUp();
        }
        if (Input.GetMouseButtonDown(0))
        {
            auraPrefab.SetActive(true);

            auraPrefab.transform.position = Player.transform.position;
            auraPrefab.transform.rotation = Quaternion.Euler(0, Player.transform.rotation.eulerAngles.y, 0);
            if (movementScript != null)
            {
                movementScript.enabled = false;
            }
        }
         if (Input.GetKeyDown(KeyCode.Return))
        {            
                auraPrefab.SetActive(false);
                
                movementScript.enabled = true;   
        }
       //SSSS animator.SetFloat("speed", Movement.Instance.moveDirection.magnitude);
        Debug.Log(Movement.Instance.moveDirection.magnitude);
        UpdateScoreDisplay();

    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("Timer- {0:00}:{1:00}", minutes, seconds);
    }

    void TimeIsUp()
    {
        gameOver();
        Debug.Log("Time is up!");
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name.Contains("Point"))
        {
            score++;
            PlayerPrefs.SetInt("Score", score);
            
            collision.gameObject.SetActive(false);
            
            UpdateScoreDisplay();
        }

        if (collision.gameObject.name.Contains("Border"))
        {
            gameOver();
        }
    }

    void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + PlayerPrefs.GetInt("Score").ToString(); 
    }
    public void gameOver()
    {
        score = 0;
        PlayerPrefs.SetInt("Score", 0);
        Player.transform.position = newPosition;
        UpdateScoreDisplay();
        timeRemaining = 60f;
        foreach (GameObject obj in allObjects)
        {
            if (obj.name == "Point")
            {
                obj.SetActive(true);
            }
        }
        auraPrefab.SetActive(false);
    }
}

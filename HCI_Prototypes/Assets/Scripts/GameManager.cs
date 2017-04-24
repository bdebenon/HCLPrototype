using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

	public static GameManager gManager = null;
    public Order order;

    //Game Objects Array
    public Transform[] gameObjectsArray;

    public GameObject mainMenu;
	public GameObject burgerMenu;
	public GameObject drinksMenu;
	public GameObject sidesMenu;
	public GameObject viewMenu;
	public GameObject checkoutMenu;

	public ButtonManager bManager;

    public string currentMenu;
    public Stack<string> previousMenu;

	// Use this for initialization
	void Start () {

		if (gManager == null) {
			gManager = this;
		} 
		else if (gManager != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);
    }

	public void changeScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
        //if (sceneName == "Instructing")
        //{
            Debug.Log("INITIALIZING");
            //initializeScene();
        //}
    }

    //Helper Functions
    void generateObjectArray()
    {
        Object[] tempList = Resources.FindObjectsOfTypeAll(typeof(GameObject));
        GameObject temp = null;
        foreach (Object obj in tempList)
        {
            if (obj is GameObject)
            {
                temp = (GameObject)obj;
                //Debug.Log(temp.name);
                if (temp.name == "Canvas")
                    break;
            }
        }
        gameObjectsArray = temp.GetComponentsInChildren<Transform>(true);
    }
    public GameObject findGameObject(string s)
    {
        for (int i = 0; i < gameObjectsArray.Length; ++i)
        {
            if (gameObjectsArray[i].gameObject.name == s)
            {
                return gameObjectsArray[i].gameObject;
            }
        }
        return null;
    }
    void loadGameObjects()
    {
        mainMenu = findGameObject("MenuMain");
        burgerMenu = findGameObject("MenuBurger");
        drinksMenu = findGameObject("MenuDrinks");
        sidesMenu = findGameObject("MenuSides");
        viewMenu = findGameObject("MenuViewOrder");
        checkoutMenu = findGameObject("MenuCheckout");
    }

    void initializeScene()
    {
        List<GameObject> objs = new List<GameObject>();
        order = new Order();
        previousMenu = new Stack<string>();
        currentMenu = "Main";
    }

    void OnEnable()
    {
        //Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        //Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change as soon as this script is disabled. Remember to always have an unsubscription for every delegate you subscribe to!
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        //Debug.Log("Level Loaded");
        Debug.Log(scene.name);
        //Debug.Log(mode);
        //Load all gameObjects into gameObjectsArray
        generateObjectArray();
        loadGameObjects();
        initializeScene();
        }

    // Update is called once per frame
    void Update () {
		
	}
}

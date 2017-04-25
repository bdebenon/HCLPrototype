using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

	public static GameManager gManager = null;
    public Order order;
	public FunctionManager functionManager;
    public DropZone dropZone;
    public Scene currentScene;

    //Game Objects Array
    public List<Transform> gameObjectsArray;

    public GameObject mainMenu;
	public GameObject burgerMenu;
	public GameObject drinksMenu;
	public GameObject sidesMenu;
	public GameObject viewMenu;
	public GameObject checkoutMenu;
    public GameObject paymentMenu;

	public GameObject cup;
	public GameObject fries;
	public GameObject onionRings;
	public GameObject iceCream;
	public GameObject Cheeseburger;
	public GameObject Hamburger;
	public GameObject ChickenBurger;
	public GameObject BaconBurger;

    
    public GameObject drinksTray;
	public GameObject sidesTray;
	public GameObject burgersTray;

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
		Transform [] tempTranforms = temp.GetComponentsInChildren<Transform>(true);
		for(int i = 0; i < tempTranforms.Length; ++i) {
			gameObjectsArray.Add(tempTranforms[i]);
		}
    }
    public GameObject findGameObject(string s)
    {
		for (int i = 0; i < gameObjectsArray.Count; ++i)
        {
			if (gameObjectsArray [i].gameObject != null) {
				if (gameObjectsArray[i].gameObject.name == s)
				{
					return gameObjectsArray[i].gameObject;
				}
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
        paymentMenu = findGameObject("MenuPayment");
    }

    public void initializeScene()
    {
        List<GameObject> objs = new List<GameObject>();
        order = new Order();
        previousMenu = new Stack<string>();
        currentMenu = "Main";
    }
    public void LoadMainMenu()
    {
        mainMenu.SetActive(true);
        burgerMenu.SetActive(false);
        drinksMenu.SetActive(false);
        sidesMenu.SetActive(false);
        viewMenu.SetActive(false);
        checkoutMenu.SetActive(false);
        paymentMenu.SetActive(false);
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
        //Debug.Log(scene.name);
        if (scene.name == "Manipulating" || scene.name == "Instructing")
        {
            generateObjectArray();
            loadGameObjects();
            initializeScene();
            LoadMainMenu();
        }
        currentScene = scene;
        Debug.Log(scene.name);
        
        if(scene.name == "Manipulating")
        {
            drinksTray = findGameObject("DrinksTray");
			sidesTray = findGameObject ("SidesTray");
			burgersTray = findGameObject ("BurgersTray");
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour
{
    const string PSController = "Sony Interactive Entertainment Wireless Controller";
    private const string MainMenu = "Menu";

    [SerializeField] GameObject XBox;
    [SerializeField] GameObject PS;

    // Start is called before the first frame update
    void Start()
    {
        // show correct controller
        var joysticks = Input.GetJoystickNames();
        if (joysticks.Length > 0)
        {
            var joystick = joysticks[0];
            PS.SetActive(joystick == PSController);
            XBox.SetActive(joystick != PSController);
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire3")) // B
        {
            OnClickBack();
        }
    }

    public void OnClickBack()
    {
        SceneManager.LoadScene(MainMenu);
    }
}

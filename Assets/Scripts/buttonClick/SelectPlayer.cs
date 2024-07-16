using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SelectPlayer : MonoBehaviour
{  
    [SerializeField]private int index;

    private Button btn;
    
    
    private void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClickSelectPlayer);
    }
    private void OnClickSelectPlayer()
    {
        PlayerPrefs.SetInt("SelectedPlayer", index);
        SceneManager.LoadScene("Main");
    }

}

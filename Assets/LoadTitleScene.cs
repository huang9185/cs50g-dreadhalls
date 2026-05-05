using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTitleScene : MonoBehaviour
{

    private AudioSource soundSource;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake() 
    {
        soundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Submit") == 1){
            Destroy(soundSource.gameObject);
			SceneManager.LoadScene("Title");
		}
    }
}

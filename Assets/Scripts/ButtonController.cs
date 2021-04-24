using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public Text ButtonText;
    public Animator animator;
    public Image Image;

    public void NextRoom()
    {
        StartCoroutine(Fade());
        SceneManager.LoadScene(ButtonText.text + "Scene");
    }

    IEnumerator Fade()
    {
        animator.SetBool("IsFading", true);
        yield return new WaitUntil(() => Image.color.a == 1);
    }
}

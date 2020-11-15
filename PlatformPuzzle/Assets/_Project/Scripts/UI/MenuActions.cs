namespace UI
{
    using UnityEngine;
    using Base;

    public class MenuActions : MonoBehaviour
    {
        public GameObject currentActive;
        public AudioSource sfxPlayer;
        public SFXWrapper buttonInteract;

        public void SwitchToScreen(GameObject nextScreen)
        {
            currentActive.SetActive(false);
            nextScreen.SetActive(true);
            currentActive = nextScreen;

            buttonInteract.PlaySoundClip(sfxPlayer);
        }


        public void GoToScene(int sceneIndex)
        {
            buttonInteract.PlaySoundClip(sfxPlayer);

            GameManager.Instance.MoveToNextLevel(sceneIndex);
        }

        public void QuitGame()
        {
            buttonInteract.PlaySoundClip(sfxPlayer);

            Application.Quit();
        }
    }
}
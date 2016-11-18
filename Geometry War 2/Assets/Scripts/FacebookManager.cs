using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;
using System.Collections.Generic;

public class FacebookManager : MonoBehaviour 
{
    public Text userIdText;

    private void Awake()
    {
        if (!FB.IsInitialized)
        {
            FB.Init();
        }
        else
        {
            FB.ActivateApp();
        }
    }

    public void LogIn()
    {
        FB.LogInWithReadPermissions(callback:OnLogIn);
    }

    private void OnLogIn(ILoginResult result)
    {
        if (FB.IsLoggedIn)
        {
            AccessToken token = AccessToken.CurrentAccessToken;
            userIdText.text = token.UserId;
        }
        else
        {
            Debug.Log("Canceled Login");
        }
    }

    public void Share()
    {
        FB.ShareLink(contentTitle: "Geometry War 2",
                     contentURL: new System.Uri("https://www.amazon.com.br/s?ie=UTF8&field-keywords=Railson&index=mobile-apps&search-type=ss"),
                     contentDescription: "Link para download do jogo!",
                     callback:OnShare);
    }
    
    private void OnShare(IShareResult result)
    {
        if (result.Cancelled || !string.IsNullOrEmpty(result.Error))
        {
            Debug.Log("Share link error: " + result.Error);
        }
        else if (!string.IsNullOrEmpty(result.PostId))
        {
            Debug.Log(result.PostId);
        }
        else
            Debug.Log("Share succeed");
    }

    public void Invite()
    {
        FB.AppRequest(message: "This game is awesome , join me, now",
                      title: "Invite your friends to join you");
    }
}
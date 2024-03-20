using System.Collections;
using System.Collections.Generic;
using Firebase.Auth;
using UnityEngine.UI;
using UnityEngine;

public class AuthManager : MonoBehaviour
{
    [SerializeField] InputField emailField;
    [SerializeField] InputField passwordField; // 이메일과 패스워드 입력을 받기위한 UI 요소

    Firebase.Auth.FirebaseAuth auth; // Firebase 인증과 관련된 메서드를 호출하기 위한 객체

    void Awake()
    {
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance; // Firebase 인증시스템이 인스턴스 auth 변수를 연결함    
    }

    public void Login()
    {
        auth.SignInWithEmailAndPasswordAsync(emailField.text, passwordField.text).ContinueWith( // ContinueWith :
                                                                                                // Task가 끝난 뒤에 무엇을 할 것인가에 대한 정의
            task =>
            {
                if (task.IsCompleted && !task.IsFaulted && !task.IsCanceled)
                {
                    Debug.Log(emailField.text + "로 로그인하셨습니다.");
                }
                else
                {
                    Debug.Log("로그인에 실패하였습니다.");
                }
            });
    }

    public void Register()
    {
        auth.CreateUserWithEmailAndPasswordAsync(emailField.text, passwordField.text).ContinueWith(
            task =>
            {
                if (task.IsCompleted && !task.IsFaulted && !task.IsCanceled)
                {
                    Debug.Log(emailField.text + "로 회원가입\n");
                }
                else
                {
                    Debug.Log("회원가입 실패\n");
                }
            });
    }
}

using UnityEngine;

namespace AppleBoiy.HelloUnity
{
public class MyScripts : MonoBehaviour
{
    public void Greet()
    {
        Debug.Log("Hello, World!");
    }
    
    public static void GreetStatic()
    {
        Debug.Log("Hello, World! (Static)");
    }
}

}

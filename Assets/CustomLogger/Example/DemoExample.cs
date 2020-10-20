using raion.CustomLogger;
using UnityEngine;

public class DemoExample : MonoBehaviour
{
    
    void Start()
    {
        Console.Info("Progrise");
        Console.Warn("Warning, Warning this is not a test", this);
        Console.Error(this, "Shining Assault Hopper");      
    }
}

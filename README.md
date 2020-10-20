# Custom Logger Unity
An custom and simple logging system for Unity. In this logging system contain 3 level of loging: Green mean Information, Yellow mean Warning and Red mean Error.

## A. Example

### 1. Code 

```c#
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
```

### 2. Result

![example](https://github.com/Prima20/Custom-Logger-Unity/blob/master/images/example.JPG)
using UnityEngine;
using System.Collections;

namespace Pan_Tools
{
    public class DebugPan
    {
        //分平台输出不同的Debug
        public static void Log(object message)
        {
#if UNITY_EDITOR
            Debug.Log(message);
#endif
        }
    }

}

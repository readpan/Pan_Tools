using UnityEngine;
using System.Collections;
/// <summary>
/// 一个物体跟随另一个物体
/// </summary>
public class FollowGameObject : MonoBehaviour
{
    /// <summary>
    /// 目标物体
    /// </summary>
    [Tooltip("目标物体")]
    public Transform ToFollowTargetTransform;
    [Tooltip("想要保持的距离")]
    public Vector3 DistanceVector3;
    void Update()
    {
        transform.position = ToFollowTargetTransform.position + DistanceVector3;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class HelperClasses
{
    public static float CalculateDistance(Transform object1, Transform object2)
    {
        if (object1 != null && object2 != null)
        {
            return Vector3.Distance(object1.position, object2.position);
        }

        Debug.LogError("Please provide valid Transform references.");
        return -1f; // or some value to indicate an error or invalid result
    }
    public static class ScreenBounds
    {
        public static float MinX => Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        public static float MaxX => Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        public static float MinY => Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        public static float MaxY => Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
    }
    public static void RotateToPlayer(Transform objectToRotate, Transform target)
    {
        RotateToPlayer(objectToRotate,target,float.MaxValue);
    }
    public static void RotateToPlayer(Transform objectToRotate, Transform target, float rotationSpeed)
    {
        if (target != null)
        {

            Vector2 pointToTarget = target.position - objectToRotate.position;

            float angle = Mathf.Atan2(pointToTarget.y, pointToTarget.x) * Mathf.Rad2Deg + 90f;
            Quaternion targetRotation = Quaternion.Euler(new Vector3(0f, 0f, angle));


            objectToRotate.rotation = Quaternion.Slerp(objectToRotate.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        
    }

}

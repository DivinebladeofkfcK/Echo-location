//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class spherecast : MonoBehaviour
//{
//    public float CastDistance = 10f;

//    // Update is called once per frame
//    public void Echo()
//    {

//       Collider[] hits = Physics.OverlapSphere(transform.position, CastDistance);
//        foreach (Collider hit in hits)
//        {
//            Debug.Log($"Detected: {hit.name}");

//        }


//    }
//    void OnDrawGizmosSelected()
//    {

//        Gizmos.color = Color.red;
//        Gizmos.DrawWireSphere(transform.position, CastDistance);

//    }
   
//}



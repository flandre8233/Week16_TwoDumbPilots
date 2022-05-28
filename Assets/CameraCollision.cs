using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    public Transform TargetTrans;

   [SerializeField] SphericalCoordinate sphericalCoordinate;

    public void Update()
    {
        sphericalCoordinate.Radius = cameraCollision();
        print(cameraCollision() );
    }

    public float cameraCollision()
    {
        Vector3 startPoint = TargetTrans.position;
        Quaternion rotate = getVector3ToVector3LookAtRotation3D(startPoint, transform.position);
        //目標Layer
        int layer_mask = LayerMask.GetMask("Default");
        Ray ray = new Ray(startPoint, rotate * Vector3.forward);
        RaycastHit hit;

        //Debug.DrawRay(startPoint, rotate * Vector3.forward, Color.red);
        if (Physics.Raycast(ray, out hit, 7.5f, layer_mask) && hit.transform.tag == "background")
        {
            return Vector3.Distance(startPoint, hit.point);
        }
        return 7.5f;
    }

    public Quaternion getVector3ToVector3LookAtRotation3D(Vector3 lookAtPointX, Vector3 lookAtPointY)
    {
        Vector3 relativePos = lookAtPointY - lookAtPointX;
        return Quaternion.LookRotation(relativePos);
    }

}

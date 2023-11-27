using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Umbrella : MonoBehaviour
{
    public XRController rightHandController; // 오른손 컨트롤러를 연결해야 합니다.
    public Transform umbrella; // Umbrella 오브젝트를 연결합니다.

    void Update()
    {
        if (rightHandController)
        {
            // 오른손 컨트롤러의 위치와 회전 가져오기
            Vector3 controllerPosition = rightHandController.transform.position;
            Quaternion controllerRotation = rightHandController.transform.rotation;

            // Umbrella 오브젝트에 컨트롤러의 위치와 회전 적용
            umbrella.position = controllerPosition;
            umbrella.rotation = controllerRotation;
        }
    }
}

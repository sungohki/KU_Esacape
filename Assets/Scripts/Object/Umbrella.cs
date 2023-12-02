using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Umbrella : MonoBehaviour
{
    public XRController rightHandController; // ������ ��Ʈ�ѷ��� �����ؾ� �մϴ�.
    public Transform umbrella; // Umbrella ������Ʈ�� �����մϴ�.

    void Update()
    {
        if (rightHandController)
        {
            // ������ ��Ʈ�ѷ��� ��ġ�� ȸ�� ��������
            Vector3 controllerPosition = rightHandController.transform.position;
            Quaternion controllerRotation = rightHandController.transform.rotation;

            // Umbrella ������Ʈ�� ��Ʈ�ѷ��� ��ġ�� ȸ�� ����
            umbrella.position = controllerPosition;
            umbrella.rotation = controllerRotation;
        }
    }

    
}

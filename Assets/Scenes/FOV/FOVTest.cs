using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class FOVTest : MonoBehaviour
{
    [Range(1f, 179f)] public float m_fov = 40f;
    public Camera m_camera;
    public Transform m_lens;
    public Transform m_line1;
    public Transform m_line2;
    public Transform m_line3;
    public Transform m_line4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_camera.fieldOfView = m_fov;
        Vector3 lensPos = m_lens.localPosition;
        lensPos.z = Mathf.Tan(Mathf.Deg2Rad * (180f - m_fov) * 0.5f) * 0.5f;
        m_lens.localPosition = lensPos;
        m_camera.transform.localPosition = lensPos * 0.5f;
        Vector3 lineScale = new Vector3(0.01f, 0.01f, lensPos.z);
        lineScale.z = Mathf.Sqrt((lensPos.z * lensPos.z) + (0.5f * 0.5f));
        m_line1.transform.localScale = lineScale;
        m_line2.transform.localScale = lineScale;
        m_line3.transform.localScale = lineScale;
        m_line4.transform.localScale = lineScale;
    }
}

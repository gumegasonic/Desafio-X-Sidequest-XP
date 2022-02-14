using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCannon : MonoBehaviour
{
    public Camera cam;
    public LineRenderer lineRenderer;
    public Transform firePoint;
    public Transform endPoint;
    public GameObject startVFX;
    public GameObject endVFX;
    public GameObject damage;

    private Quaternion rotation;
    private List<ParticleSystem> particles = new List<ParticleSystem>();

    public LayerMask layerMask;
    public LayerMask inimigos;

    public AudioSource m_shootingSound;
    public AudioClip shootSound;
    [Range(0, 1)]
    public float volume;
    void Start()
    {
        FillLists();
        DisableLaser();
    }

    private void OnEnable()
    {
        m_shootingSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            EnableLaser();
        }

        if (Input.GetMouseButton(0))
        {
            UpdateLaser();
        }

        if (Input.GetMouseButtonUp(0))
        {
            DisableLaser();
        }
    }

    void FillLists()
    {
        for (int i = 0; i < startVFX.transform.childCount; i++)
        {
            var ps = startVFX.transform.GetChild(i).GetComponent<ParticleSystem>();
            if (particles != null)
                particles.Add(ps);
        }

        for (int i = 0; i < endVFX.transform.childCount -1; i++)
        {
            var ps = endVFX.transform.GetChild(i).GetComponent<ParticleSystem>();
            if (particles != null)
                particles.Add(ps);
        }
    }

    void EnableLaser()
    {
        m_shootingSound.Play(0);
        m_shootingSound.loop = true;

        lineRenderer.enabled = true;
        damage.gameObject.SetActive(true);

        for (int i = 0; i < particles.Count; i++)
            particles[i].Play();
    }

    void UpdateLaser()
    {
        var mousePos = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);

        lineRenderer.SetPosition(0, (Vector2)firePoint.position);
        startVFX.transform.position = (Vector2)firePoint.position;

        lineRenderer.SetPosition(1, endPoint.position);

        endVFX.transform.position = lineRenderer.GetPosition(1);
    }

    void DisableLaser()
    {
        m_shootingSound.Stop();

        lineRenderer.enabled = false;
        damage.gameObject.SetActive(false);

        for (int i = 0; i < particles.Count; i++)
            particles[i].Stop();
    }
}

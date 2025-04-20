using UnityEngine;

namespace Eloi.OVNI
{
    public class MonPremierDrone : MonoBehaviour
{
    public Transform m_queBouger;

        [Header("Speed")]
    public float m_vitesseToutDirection = 1;
    public float m_vitesseDeRotation = 180f;

        [Header("Input")]

        [Range(-1, 1)]
    public float m_pourcentVersAvant = 0;
    [Range(-1, 1)]
    public float m_pourcentVersDroit = 0;
    [Range(-1, 1)]
    public float m_pourcentVersHaut = 0;

    [Range(-1, 1)]
    public float m_pourcentRotation = 0;


    public void SetGaucheDroite(float percentGaucheDroite) {
        m_pourcentVersDroit = percentGaucheDroite;
    }

   void Update()
    {
        float delta = Time.deltaTime;

        m_queBouger.Translate(
            Vector3.forward *
            delta *
            m_vitesseToutDirection *
            m_pourcentVersAvant
            , Space.Self);
        m_queBouger.Translate(
            Vector3.up *
            delta *
            m_vitesseToutDirection *
            m_pourcentVersHaut
            , Space.Self);
        m_queBouger.Translate(
            Vector3.right *
            delta *
            m_vitesseToutDirection *
            m_pourcentVersDroit
            , Space.Self);

        m_queBouger.Rotate(0,
            m_vitesseDeRotation *
            delta *
            m_pourcentRotation
            , 0, 
            Space.Self);



        
    }
}

}
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

// Coloca um cubo onde o usuário tocar, em cima de um plano detectado.
[RequireComponent(typeof(ARRaycastManager))]
public class ColocarCubo : MonoBehaviour
{
    [Tooltip("O prefab do cubo que vai aparecer no mundo real")]
    [SerializeField] private GameObject prefabCubo;

    [Tooltip("Metade da altura do cubo, para ele ficar apoiado na superfície")]
    [SerializeField] private float alturaAcimaDoPlano = 0.05f;

    private ARRaycastManager raycastManager;
    private static readonly List<ARRaycastHit> acertos = new List<ARRaycastHit>();

    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    private void Update()
    {
        // 1. Existe tela de toque e houve um toque neste frame?
        if (Touchscreen.current == null) return;
        var toque = Touchscreen.current.primaryTouch;
        if (!toque.press.wasPressedThisFrame) return;

        Vector2 posicaoNaTela = toque.position.ReadValue();

        // 2. Lança um raio do dedo até os planos detectados
        if (raycastManager.Raycast(posicaoNaTela, acertos, TrackableType.PlaneWithinPolygon))
        {
            // 3. Pega o ponto mais próximo e sobe meio cubo
            Pose pose = acertos[0].pose;
            Vector3 posicao = pose.position + Vector3.up * alturaAcimaDoPlano;

            // 4. Cria uma cópia do cubo nesse lugar
            Instantiate(prefabCubo, posicao, pose.rotation);
        }
    }
}
using UnityEngine;
using UnityEngine.InputSystem;

public class PettingHandler : MonoBehaviour
{
    private ParticleSystem _ps;

    private void Awake()
    {
        _ps = GetComponent<ParticleSystem>();
    }

    private void Update() // TODO ACTUALLY LOOK INTO HERE WHAT IS HAPPENING AND MAKE IT WORK IN A GOOD WAY
    {
        if (!TryGetPressScreenPos(out Vector2 screenPos))
            return;

        var cam = Camera.main;
        if (cam == null) return;

        Ray ray = cam.ScreenPointToRay(screenPos);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
        if (!hit.collider) return;

        if (hit.collider.transform != transform && !hit.collider.transform.IsChildOf(transform))
            return;

        _ps.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        _ps.transform.position = transform.position;
        _ps.Play(true);
        Debug.Log("pet");
        _ps.Emit(12);
    }

    private static bool TryGetPressScreenPos(out Vector2 screenPos)
    {
        // Touch (Android)
        if (Touchscreen.current != null)
        {
            var touch = Touchscreen.current.primaryTouch;

            if (touch.press.wasPressedThisFrame)
            {
                screenPos = touch.position.ReadValue();
                return true;
            }
        }

        // Mouse (Editor / Desktop)
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            screenPos = Mouse.current.position.ReadValue();
            return true;
        }

        screenPos = default;
        return false;
    }
}

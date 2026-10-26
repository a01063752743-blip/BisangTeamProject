using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Seonho._01.Scripts
{
    public class DocumentView : MonoBehaviour
    {
        [SerializeField] private float duration;
        [SerializeField] private Ease ease;
        [SerializeField] private GameObject _document;
        
        private void Update()
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                SlideViewDocument();
            }
        }

        void SlideViewDocument()
        {
            _document.transform.position = new Vector3(0, -10, 0);
            _document.SetActive(true);
            _document.transform.DOMove(transform.position + new Vector3(0,-1.5f,0), duration).SetEase(ease);
        }
    }
}

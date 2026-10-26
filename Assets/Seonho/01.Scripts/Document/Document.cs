using System;
using Seonho._09.SO.Scripts;
using TMPro;
using UnityEngine;

namespace Seonho._01.Scripts
{
    public class Document : MonoBehaviour
    {
        [SerializeField] private DocumentWritingDataSO _documentDataSO;

        [SerializeField] private TextMeshProUGUI _writing;

        private void Awake()
        {
            Initialize();
        }

        void Initialize()
        {
            _writing.SetText(_documentDataSO.writing);
        }
    }
}

using UnityEngine;

namespace Seonho._01.Scripts.LineRenderer
{
    public class HeartRate : MonoBehaviour
    {
        [SerializeField] private Transform _centerTrm;
        [SerializeField] private UnityEngine.LineRenderer _lineRenderer;

        [SerializeField] private int _currentLineCount;
        [SerializeField] private float _currentPositionX;

        private void Awake()
        {
            _lineRenderer = GetComponent<UnityEngine.LineRenderer>();
            
            InitializeLineRenderer();
                
            ChangeLine(-1, 5, 3);
            ChangeLine(-0.5f, 6, 3);
            ChangeLine(-1f, 5, 4);
            ChangeLine(-1.5f, 7, 2);
        }

        void InitializeLineRenderer()
        {
            _lineRenderer.useWorldSpace = true;

            _currentPositionX = _centerTrm.position.x;
            
            AddLinePositionCount(2);
            _lineRenderer.SetPosition(0, transform.position);
            _lineRenderer.SetPosition(1, new Vector3(_currentPositionX, 0, 0));
        }

        private void Update()
        {
            
        }

        void AddLinePositionCount(int addCount)
        {
            _currentLineCount += addCount;
            _lineRenderer.positionCount += addCount;
        }

        void ChangeLine(float lowest, float highest, float distance)
        {
            AddLinePositionCount(4);
            _currentPositionX += 0.5f;
            _lineRenderer.SetPosition(_currentLineCount - 4, new Vector3(_currentPositionX, lowest, 0));
            _currentPositionX += 0.5f;
            _lineRenderer.SetPosition(_currentLineCount - 3, new Vector3(_currentPositionX, highest, 0));
            _currentPositionX += 0.5f;
            _lineRenderer.SetPosition(_currentLineCount - 2, new Vector3(_currentPositionX, _centerTrm.position.y, 0));
            _currentPositionX += distance;
            _lineRenderer.SetPosition(_currentLineCount - 1, new Vector3(_currentPositionX, _centerTrm.position.y, 0));
        }
    }
}

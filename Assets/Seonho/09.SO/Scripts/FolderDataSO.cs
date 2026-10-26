using UnityEngine;
using UnityEngine.Serialization;

namespace Seonho._09.SO.Scripts
{
    [CreateAssetMenu(fileName = "FolderDataSO", menuName = "SO/FolderDataSO")]
    public class FolderDataSO : ScriptableObject
    {
        public DocumentWritingDataSO documentWritingDataSo;
        public Sprite sprite;
    }
}

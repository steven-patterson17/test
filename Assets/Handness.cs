using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Keeps track of which hand the user
/// is training
/// </summary>
namespace VRTraining
{
    public class HandednessUI : MonoBehaviour
    {
        public void SetRightHanded()
        {
            SessionMetricsManager.SetLeftHanded(false);
        }
    
        public void SetLeftHanded()
        {
            SessionMetricsManager.SetLeftHanded(true);
    
        }
    
    }
}

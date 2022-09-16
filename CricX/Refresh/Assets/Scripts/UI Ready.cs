using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIReady : MonoBehaviour
{
    // Start is called before the first frame update
   
        [SerializeField]
        public bool IsUIOverride { get; private set; }

        void Update()
        {
            // It will turn true if hovering any UI Elements
            IsUIOverride = EventSystem.current.IsPointerOverGameObject();
        }
        void OnDisable()
        {
            IsUIOverride = false;
        }
    
}


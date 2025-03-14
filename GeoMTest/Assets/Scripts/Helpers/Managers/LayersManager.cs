﻿using UnityEngine;

namespace Helpers.Managers
{
    static class LayersManager
    {
        public const string UI = "UI";
        public const string DEFAULT = "Default";
        public const string GROUND = "Ground";
        public const string INTERACTABLE = "Interactable";

        public const int DEFAULT_LAYER = 0;
        
        static LayersManager()
        {
            DefaultLayer = LayerMask.GetMask(DEFAULT);
            UiLayer = LayerMask.GetMask(UI);
            Ground = LayerMask.GetMask(GROUND);
            Interactable = LayerMask.GetMask(INTERACTABLE);
        }
        
        public static int DefaultLayer { get; }
        public static int UiLayer { get; }
        public static int Ground { get; }
        public static int Interactable { get; }
    }
}

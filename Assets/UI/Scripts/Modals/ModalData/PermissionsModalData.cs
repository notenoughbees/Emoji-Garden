// Copyright 2022-2024 Niantic.
using UnityEngine;

namespace Niantic.Lightship.AR.Samples
{
    //Uncomment this line if you want to create custom modal data
    //[CreateAssetMenu(fileName = "TwoButtonWithImageModalData", menuName = "Lightship UX Toolkit/Scriptable Objects/Modal Data/ Permissions Modal Data")]
    public class PermissionsModalData : OneButtonModalData
    {
        [SerializeField]
        private Texture2D image;

        [SerializeField]
        private string denyText;

        public Texture2D ModalImage => image;
        public string DenyText => denyText;
    }
}
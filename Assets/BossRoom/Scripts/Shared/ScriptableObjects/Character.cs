using System;
using UnityEngine;

namespace BossRoom
{
    /// <summary>
    /// This ScriptableObject defines a Player Character for BossRoom. It defines its CharacterClass field for
    /// associated game-specific properties, as well as its graphics representation.
    /// </summary>
    [CreateAssetMenu]
    [Serializable]
    public class Character : GuidScriptableObject
    {
        public CharacterClass CharacterClass;

        public GameObject Graphics;

        public GameObject GraphicsCharacterSelect;
    }
}

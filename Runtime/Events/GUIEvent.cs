#nullable enable

using UnityEngine;

namespace Popcron
{
    public readonly struct GUIEvent : IEvent
    {
        public readonly Event current;

        public GUIEvent(Event current)
        {
            this.current = current;
        }
    }
}
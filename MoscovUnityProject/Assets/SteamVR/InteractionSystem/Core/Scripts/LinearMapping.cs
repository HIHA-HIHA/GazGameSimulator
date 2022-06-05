//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: A linear mapping value that is used by other components
//
//=============================================================================

using UnityEngine;
using System.Collections;
using UnityEngine.Events;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class LinearMapping : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent onChangeValue;

		private float _value;
		public float value
        {
            get
            {
				return _value;
            }
            set
            {
				_value = value;
				onChangeValue?.Invoke();
            }
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ShaderID
{
	public static int ColorID
	{
		get
		{
			return Shader.PropertyToID("_Color");
		}
		private set {}
	}
}
public static class AnimatorHash
{
	public static int Jump
	{
		get
		{
			return Animator.StringToHash("Jump");
		}
		private set {}
	}
}

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[VisibleToOtherModules(new string[]
	{
		"UnityEngine.UIElementsModule"
	})]
	internal sealed class GUIClip
	{
		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		})]
		internal struct ParentClipScope : IDisposable
		{
			private bool m_Disposed;

			public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect)
			{
				this.m_Disposed = false;
				GUIClip.Internal_PushParentClip(objectTransform, clipRect);
			}

			public void Dispose()
			{
				if (!this.m_Disposed)
				{
					this.m_Disposed = true;
					GUIClip.Internal_PopParentClip();
				}
			}
		}

		public static extern bool enabled
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public static Rect topmostRect
		{
			get
			{
				Rect result;
				GUIClip.INTERNAL_get_topmostRect(out result);
				return result;
			}
		}

		public static Rect visibleRect
		{
			get
			{
				Rect result;
				GUIClip.INTERNAL_get_visibleRect(out result);
				return result;
			}
		}

		internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIClip.Internal_Push(screenRect, scrollOffset, renderOffset, resetOffset);
		}

		internal static void Pop()
		{
			GUIClip.Internal_Pop();
		}

		public static Vector2 Unclip(Vector2 pos)
		{
			GUIClip.Unclip_Vector2(ref pos);
			return pos;
		}

		public static Rect Unclip(Rect rect)
		{
			GUIClip.Unclip_Rect(ref rect);
			return rect;
		}

		public static Vector2 Clip(Vector2 absolutePos)
		{
			GUIClip.Clip_Vector2(ref absolutePos);
			return absolutePos;
		}

		public static Rect Clip(Rect absoluteRect)
		{
			GUIClip.Internal_Clip_Rect(ref absoluteRect);
			return absoluteRect;
		}

		public static Vector2 UnclipToWindow(Vector2 pos)
		{
			GUIClip.UnclipToWindow_Vector2(ref pos);
			return pos;
		}

		public static Rect UnclipToWindow(Rect rect)
		{
			GUIClip.UnclipToWindow_Rect(ref rect);
			return rect;
		}

		public static Vector2 ClipToWindow(Vector2 absolutePos)
		{
			GUIClip.ClipToWindow_Vector2(ref absolutePos);
			return absolutePos;
		}

		public static Rect ClipToWindow(Rect absoluteRect)
		{
			GUIClip.ClipToWindow_Rect(ref absoluteRect);
			return absoluteRect;
		}

		public static Vector2 GetAbsoluteMousePosition()
		{
			Vector2 result;
			GUIClip.Internal_GetAbsoluteMousePosition(out result);
			return result;
		}

		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		})]
		internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
			GUIClip.INTERNAL_CALL_Internal_Push(ref screenRect, ref scrollOffset, ref renderOffset, resetOffset);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Push(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset);

		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		}), GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_Pop();

		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		}), GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_GetCount();

		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		})]
		internal static Rect GetTopRect()
		{
			Rect result;
			GUIClip.INTERNAL_CALL_GetTopRect(out result);
			return result;
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetTopRect(out Rect value);

		private static void Unclip_Vector2(ref Vector2 pos)
		{
			GUIClip.INTERNAL_CALL_Unclip_Vector2(ref pos);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Unclip_Vector2(ref Vector2 pos);

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_topmostRect(out Rect value);

		private static void Unclip_Rect(ref Rect rect)
		{
			GUIClip.INTERNAL_CALL_Unclip_Rect(ref rect);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Unclip_Rect(ref Rect rect);

		private static void Clip_Vector2(ref Vector2 absolutePos)
		{
			GUIClip.INTERNAL_CALL_Clip_Vector2(ref absolutePos);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Clip_Vector2(ref Vector2 absolutePos);

		private static void Internal_Clip_Rect(ref Rect absoluteRect)
		{
			GUIClip.INTERNAL_CALL_Internal_Clip_Rect(ref absoluteRect);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Clip_Rect(ref Rect absoluteRect);

		private static void UnclipToWindow_Vector2(ref Vector2 pos)
		{
			GUIClip.INTERNAL_CALL_UnclipToWindow_Vector2(ref pos);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UnclipToWindow_Vector2(ref Vector2 pos);

		private static void UnclipToWindow_Rect(ref Rect rect)
		{
			GUIClip.INTERNAL_CALL_UnclipToWindow_Rect(ref rect);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UnclipToWindow_Rect(ref Rect rect);

		private static void ClipToWindow_Vector2(ref Vector2 absolutePos)
		{
			GUIClip.INTERNAL_CALL_ClipToWindow_Vector2(ref absolutePos);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClipToWindow_Vector2(ref Vector2 absolutePos);

		private static void ClipToWindow_Rect(ref Rect absoluteRect)
		{
			GUIClip.INTERNAL_CALL_ClipToWindow_Rect(ref absoluteRect);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClipToWindow_Rect(ref Rect absoluteRect);

		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		}), GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Reapply();

		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		})]
		internal static Matrix4x4 GetMatrix()
		{
			Matrix4x4 result;
			GUIClip.INTERNAL_CALL_GetMatrix(out result);
			return result;
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetMatrix(out Matrix4x4 value);

		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		})]
		internal static void SetMatrix(Matrix4x4 m)
		{
			GUIClip.INTERNAL_CALL_SetMatrix(ref m);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetMatrix(ref Matrix4x4 m);

		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		})]
		internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect)
		{
			GUIClip.INTERNAL_CALL_Internal_PushParentClip(ref objectTransform, ref clipRect);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_PushParentClip(ref Matrix4x4 objectTransform, ref Rect clipRect);

		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		}), GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_PopParentClip();

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_visibleRect(out Rect value);

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetAbsoluteMousePosition(out Vector2 output);
	}
}

﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.UIElements.VisualElementFocusChangeDirection
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

namespace UnityEngine.Experimental.UIElements
{
  /// <summary>
  ///   <para>Define focus change directions for the VisualElementFocusRing.</para>
  /// </summary>
  public class VisualElementFocusChangeDirection : FocusChangeDirection
  {
    private static readonly VisualElementFocusChangeDirection s_Left = new VisualElementFocusChangeDirection((int) FocusChangeDirection.lastValue + 1);
    private static readonly VisualElementFocusChangeDirection s_Right = new VisualElementFocusChangeDirection((int) FocusChangeDirection.lastValue + 2);

    protected VisualElementFocusChangeDirection(int value)
      : base(value)
    {
    }

    /// <summary>
    ///   <para>The focus is moving to the left.</para>
    /// </summary>
    public static FocusChangeDirection left
    {
      get
      {
        return (FocusChangeDirection) VisualElementFocusChangeDirection.s_Left;
      }
    }

    /// <summary>
    ///   <para>The focus is moving to the right.</para>
    /// </summary>
    public static FocusChangeDirection right
    {
      get
      {
        return (FocusChangeDirection) VisualElementFocusChangeDirection.s_Right;
      }
    }

    /// <summary>
    ///   <para>Last value for the direction defined by this class.</para>
    /// </summary>
    protected static VisualElementFocusChangeDirection lastValue
    {
      get
      {
        return VisualElementFocusChangeDirection.s_Right;
      }
    }
  }
}
﻿using System.Numerics;

namespace GameFramework;

public struct FVector
{
    public float X;
    public float Y;
    public float Z;

    public FVector(float x, float y, float z) { X = x; Y = y; Z = z; }
    public FVector GetSafeNormal() { return default; }
    public static FVector operator *(FVector v, float f) { return new FVector(); }
    public static FVector operator +(FVector v, FVector f) { return new FVector(); }
    public static FVector operator -(FVector v, FVector f) { return new FVector(); }

    /** A zero vector (0,0,0) */
    public static FVector ZeroVector;

    /** One vector (1,1,1) */
    public static FVector OneVector;

    /** Unreal up vector (0,0,1) */
    public static FVector UpVector;

    /** Unreal down vector (0,0,-1) */
    public static FVector DownVector;

    /** Unreal forward vector (1,0,0) */
    public static FVector ForwardVector;

    /** Unreal backward vector (-1,0,0) */
    public static FVector BackwardVector;

    /** Unreal right vector (0,1,0) */
    public static FVector RightVector;

    /** Unreal left vector (0,-1,0) */
    public static FVector LeftVector;

    /** Unit X axis vector (1,0,0) */
    public static FVector XAxisVector;

    /** Unit Y axis vector (0,1,0) */
    public static FVector YAxisVector;

    /** Unit Z axis vector (0,0,1) */
    public static FVector ZAxisVector;


}


﻿#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;

public enum ELevelTick
{
    LEVELTICK_TimeOnly = 0,
    LEVELTICK_ViewportsOnly = 1,
    LEVELTICK_All = 2,
    LEVELTICK_PauseTick = 3,
}

public partial class UActorComponent : UObject
{
    public UWorld GetWorld() { return default; }

    public virtual void BeginPlay() { }
    public virtual void TickComponent(float Delta, ELevelTick TickType, [CppPointer] FActorComponentTickFunction ThisTickFunction) { }

    public T GetOwner<T>() { return default; }
}

public partial class USceneComponent : UActorComponent
{
    public virtual void BeginPlay() { }
    public void SetupAttachment(USceneComponent InParent, string InSocketName) { }
    public void SetupAttachment(USceneComponent InParent) { }
    public void SetRelativeLocation(FVector loc) { }
    public void SetUsingAbsoluteRotation(bool bInAbsoluteRotation) { }
    public void SetRelativeRotation(FRotator NewRotation, bool bSweep = false) { }

    public void SetRelativeRotation(FRotator NewRotation) { }
    public void SetRelativeTransform(FTransform NewTransform) { }
    public void AddRelativeLocation(FVector DeltaLocation) { }
    public void AddRelativeRotation(FRotator DeltaRotation) { }
    public void AddLocalOffset(FVector DeltaLocation) { }
    public void AddLocalRotation(FRotator DeltaRotation) { }
    public void AddLocalTransform(FTransform DeltaTransform) { }
    public void SetWorldLocation(FVector NewLocation) { }
    public void SetWorldRotation(FRotator NewRotation) { }

    public void SetWorldTransform(FTransform NewTransform) { }
    public void AddWorldOffset(FVector DeltaLocation) { }
    public void AddWorldRotation(FRotator DeltaRotation) { }
    public void AddWorldTransform(FTransform DeltaTransform) { }
    public void AddWorldTransformKeepScale(FTransform DeltaTransform) { }

    public void AttachToComponent(USceneComponent Parent, FAttachmentTransformRules AttachmentRules, string SocketName) { }

    public FRotator GetComponentRotation() { return default; }
}


public partial class UPrimitiveComponent : USceneComponent
{
}
public partial class UShapeComponent : UPrimitiveComponent
{
}
public partial class UCapsuleComponent : UShapeComponent
{
    public void InitCapsuleSize(float InRadius, float InHalfHeight) { }
}

public partial class USpringArmComponent : USceneComponent
{
    public static string SocketName;
}

public partial class UInputComponent : UActorComponent
{
    public void BindAction(string ActionName, EInputEvent e, Object target, string a) { }
    public void BindAxis(string AxisName, Object target, string a) { }
}

public partial class UEnhancedInputComponent : UInputComponent
{

    public delegate void SimpleAction();
    public delegate void InputAction(FInputActionValue a);

    public void BindAction(UInputAction action, ETriggerEvent e, Object target, string a) { }
    //public void BindAction(UInputAction action, ETriggerEvent e, Object target, SimpleAction a) { }
    //public void BindAction(UInputAction action, ETriggerEvent e, Object target, InputAction a) { }
}

public partial class USphereComponent : UShapeComponent
{
    public void InitSphereRadius(float radius) { }
}

public partial class UMovementComponent
{
    public bool ShouldSkipUpdate(float DeltaTime) { return false; }
    public bool SafeMoveUpdatedComponent(FVector Delta, FRotator NewRotation, bool bSweep, out FHitResult OutHit) 
    { OutHit = new();
        return false; }

    public virtual float SlideAlongSurface(FVector Delta, float Time,
        FVector Normal, out FHitResult Hit, bool bHandleImpact = false)
    {
        Hit = new FHitResult();
        return default;
    }
    public virtual float SlideAlongSurface(FVector Delta, float Time,
        FVector_NetQuantize Normal, out FHitResult Hit, bool bHandleImpact = false)
    {
        Hit = new FHitResult();
        return default;
    }
}
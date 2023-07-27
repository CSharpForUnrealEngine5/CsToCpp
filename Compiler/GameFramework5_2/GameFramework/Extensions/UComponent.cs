namespace GameFramework;

public partial class UActorComponent : UObject
{
    public UWorld GetWorld() { return default; }
}
    public partial class UCapsuleComponent : UShapeComponent
{
    public void InitCapsuleSize(float InRadius, float InHalfHeight) { }
}

public partial class USceneComponent : UActorComponent
{
    public virtual void BeginPlay() { }
    public void SetupAttachment(USceneComponent InParent, string InSocketName) { }
    public void SetupAttachment(USceneComponent InParent) { }
    public void SetRelativeLocation(FVector loc) { }
    public void SetUsingAbsoluteRotation(bool bInAbsoluteRotation) { }
    public void SetRelativeRotation(FRotator NewRotation, bool bSweep = false) { }


    public void AttachToComponent(USceneComponent Parent, FAttachmentTransformRules AttachmentRules, string SocketName) { }

}

public partial class USpringArmComponent : USceneComponent
{
    public static string SocketName;
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
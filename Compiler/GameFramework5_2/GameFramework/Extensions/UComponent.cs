namespace GameFramework;

public partial class UCapsuleComponent : UShapeComponent
{
    public void InitCapsuleSize(float InRadius, float InHalfHeight) { }
}

public partial class USceneComponent : UActorComponent
{
    public void SetupAttachment(USceneComponent InParent, string InSocketName) { }
    public void SetupAttachment(USceneComponent InParent) { }

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

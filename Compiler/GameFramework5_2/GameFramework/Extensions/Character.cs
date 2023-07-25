
namespace GameFramework;

public partial class AActor : UObject
{
    public UWorld GetWorld() { return default; }
    public FVector GetActorLocation() { return default; }
}
public partial class ACharacter : APawn
{
    public UCapsuleComponent GetCapsuleComponent() { return null; }
    public UCharacterMovementComponent GetCharacterMovement() { return null; }

    public virtual void BeginPlay() { }
}

public partial class ULocalPlayer : UPlayer
{
    public static T GetSubsystem<T>(ULocalPlayer LocalPlayer) { return default(T); }
}

public partial class UEnhancedInputLocalPlayerSubsystem : ULocalPlayerSubsystem
{
    public virtual void AddMappingContext(UInputMappingContext MappingContext, int Priority) { }
    public virtual void RemoveMappingContext(UInputMappingContext MappingContext) { }
}

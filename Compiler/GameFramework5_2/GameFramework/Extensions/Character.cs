#pragma warning disable CS8618,CS8603,CS1587,CS1591

namespace GameFramework;
using CSharpToCpp.Utilities;

public partial class APawn
{
    public virtual UPawnMovementComponent GetPawnMovementComponent() { return default; }
    /** Allows a Pawn to set up custom input bindings. Called upon possession by a PlayerController, using the InputComponent created by CreatePlayerInputComponent(). */
    protected virtual void SetupPlayerInputComponent(UInputComponent PlayerInputComponent) { /* No bindings by default.*/ }

}

[CppInclude("Components/CapsuleComponent.h", 
    "GameFramework/CharacterMovementComponent.h"
    )]
public partial class ACharacter : APawn
{
    public UCapsuleComponent GetCapsuleComponent() { return default; }
    public UCharacterMovementComponent GetCharacterMovement() { return default; }

    public USkeletalMeshComponent GetMesh() { return  default; }

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

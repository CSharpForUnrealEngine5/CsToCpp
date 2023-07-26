
namespace GameFramework;
using CSharpToCpp.Utilities;


[CppInclude("Components/CapsuleComponent.h","GameFramework/CharacterMovementComponent.h")]
public partial class ACharacter : APawn
{
    public UCapsuleComponent GetCapsuleComponent() { return null; }
    public UCharacterMovementComponent GetCharacterMovement() { return null; }

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

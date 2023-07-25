#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/RotatingMovementComponent.h")]
///<summary>Performs continuous rotation of a component at a specific rotation rate.</summary>
public partial class URotatingMovementComponent : UMovementComponent {
// RotatingMovementComponent
	public FRotator RotationRate;
	public FVector PivotTranslation;
	public bool bRotationInLocalSpace;
}

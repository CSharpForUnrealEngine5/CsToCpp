#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Performs continuous rotation of a component at a specific rotation rate.</summary>
[CppInclude("GameFramework/RotatingMovementComponent.h")]
public partial class URotatingMovementComponent : UMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>How fast to update roll/pitch/yaw of the component we update.</summary>
	public FRotator RotationRate;
	///<summary>Translation of pivot point around which we rotate, relative to current rotation.</summary>
	public FVector PivotTranslation;
	///<summary>Whether rotation is applied in local or world space.</summary>
	public bool bRotationInLocalSpace;
}

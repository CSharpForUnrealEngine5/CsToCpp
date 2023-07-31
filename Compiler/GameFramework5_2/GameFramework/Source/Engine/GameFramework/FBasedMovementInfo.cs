#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to hold information about the &quot;base&quot; object the character is standing on.</summary>
[CppInclude("GameFramework/Character.h")]
public partial struct FBasedMovementInfo {
	public ushort BaseID;
	public UPrimitiveComponent MovementBase;
	public string BoneName;
	public FVector_NetQuantize100 Location;
	public FRotator Rotation;
	public bool bServerHasBaseComponent;
	public bool bRelativeRotation;
	public bool bServerHasVelocity;
}

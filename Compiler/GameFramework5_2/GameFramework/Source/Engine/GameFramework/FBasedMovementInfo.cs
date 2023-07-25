#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/Character.h")]
///<summary>Struct to hold information about the "base" object the character is standing on.</summary>
public partial struct FBasedMovementInfo {
// BasedMovementInfo
	public ushort BaseID;
	public UPrimitiveComponent MovementBase;
	public string BoneName;
	public FVector_NetQuantize100 Location;
	public FRotator Rotation;
	public bool bServerHasBaseComponent;
	public bool bRelativeRotation;
	public bool bServerHasVelocity;
}

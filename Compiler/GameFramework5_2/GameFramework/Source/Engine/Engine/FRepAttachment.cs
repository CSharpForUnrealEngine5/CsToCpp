#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles attachment replication to clients.</summary>
[CppInclude("Engine/ReplicatedState.h")]
public partial struct FRepAttachment {
	public AActor AttachParent;
	public FVector_NetQuantize100 LocationOffset;
	public FVector_NetQuantize100 RelativeScale3D;
	public FRotator RotationOffset;
	public string AttachSocket;
	public USceneComponent AttachComponent;
}

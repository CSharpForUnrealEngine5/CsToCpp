#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ReplicatedState.h")]
///<summary>Handles attachment replication to clients.</summary>
public partial struct FRepAttachment {
// RepAttachment
	public AActor AttachParent;
	public FVector_NetQuantize100 LocationOffset;
	public FVector_NetQuantize100 RelativeScale3D;
	public FRotator RotationOffset;
	public string AttachSocket;
	public USceneComponent AttachComponent;
}

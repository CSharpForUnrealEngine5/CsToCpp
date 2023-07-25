#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Struct for handling positions relative to a base actor, which is potentially moving</summary>
public partial struct FBasedPosition {
// BasedPosition
	public AActor Base;
	public FVector Position;
	public FVector CachedBaseLocation;
	public FRotator CachedBaseRotation;
	public FVector CachedTransPosition;
}

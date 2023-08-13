namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct for handling positions relative to a base actor, which is potentially moving</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FBasedPosition {
	public AActor Base;
	public FVector Position;
	public FVector CachedBaseLocation;
	public FRotator CachedBaseRotation;
	public FVector CachedTransPosition;
}

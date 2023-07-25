#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CharacterMovementComponentAsync.h")]
///<summary>Data about the floor for walking movement, used by CharacterMovementComponent.</summary>
public partial struct FFindFloorResult {
// FindFloorResult
	public bool bBlockingHit;
	public bool bWalkableFloor;
	public bool bLineTrace;
	public float FloorDist;
	public float LineDist;
	public FHitResult HitResult;
}

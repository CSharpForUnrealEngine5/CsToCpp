namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data about the floor for walking movement, used by CharacterMovementComponent.</summary>
[CppInclude("CharacterMovementComponentAsync.h")]
public partial struct FFindFloorResult {
	public bool bBlockingHit;
	public bool bWalkableFloor;
	public bool bLineTrace;
	public float FloorDist;
	public float LineDist;
	public FHitResult HitResult;
}

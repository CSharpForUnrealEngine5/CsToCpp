#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes path request along one ZoneGraph lane. If the NextLaneHandle is set, lane is changed when path finishes.</summary>
[CppInclude("MassZoneGraphNavigationTypes.h")]
public partial struct FZoneGraphShortPathRequest {
	public FVector StartPosition;
	public FVector EndOfPathPosition;
	public FZoneGraphLaneHandle NextLaneHandle;
	public float TargetDistance;
	public FMassSnorm8Vector EndOfPathDirection;
	public FMassInt16Real AnticipationDistance;
	public FMassInt16Real EndOfPathOffset;
	public EMassMovementAction EndOfPathIntent;
	public EZoneLaneLinkType NextExitLinkType;
	public bool bMoveReverse;
	public bool bIsEndOfPathPositionSet;
	public bool bIsEndOfPathDirectionSet;
}

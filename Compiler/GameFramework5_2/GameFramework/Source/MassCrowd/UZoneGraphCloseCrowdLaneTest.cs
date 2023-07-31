#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassCrowdLaneClosingTest.h")]
public partial class UZoneGraphCloseCrowdLaneTest : UZoneLaneTest {
	///<summary>LaneLocation</summary>
	public FZoneGraphLaneLocation LaneLocation;
	///<summary>CrowdSubsystem</summary>
	public UMassCrowdSubsystem CrowdSubsystem;
	///<summary>LaneState</summary>
	public ECrowdLaneState LaneState;
	///<summary>PrevLaneState</summary>
	public ECrowdLaneState PrevLaneState;
}

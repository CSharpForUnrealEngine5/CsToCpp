namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassCrowdLaneClosingTest.h")]
public partial class UZoneGraphCloseCrowdLaneTest : UZoneLaneTest {
	public static UClass StaticClass() {return default;}
	///<summary>LaneLocation</summary>
	public FZoneGraphLaneLocation LaneLocation;
	///<summary>CrowdSubsystem</summary>
	public UMassCrowdSubsystem CrowdSubsystem;
	///<summary>LaneState</summary>
	public ECrowdLaneState LaneState;
	///<summary>PrevLaneState</summary>
	public ECrowdLaneState PrevLaneState;
}

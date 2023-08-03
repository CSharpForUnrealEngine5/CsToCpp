#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/Filtering/NetObjectGridFilter.h")]
public partial class UNetObjectGridFilterConfig : UNetObjectFilterConfig {
	public static UClass StaticClass() {return default;}
	///<summary>How many frames a view position should be considered relevant. To avoid culling issues when player borders cells.</summary>
	public uint ViewPosRelevancyFrameCount;
	///<summary>CellSizeX</summary>
	public float CellSizeX;
	///<summary>CellSizeY</summary>
	public float CellSizeY;
	///<summary>Objects with larger sqrt(NetCullDistanceSqr) will be rejected.</summary>
	public float MaxCullDistance;
	///<summary>Objects without a NetCullDistanceSquared property will assume to have this value but squared unless there&#39;s a cull distance override.</summary>
	public float DefaultCullDistance;
	///<summary>Coordinates will be clamped to MinPos and MaxPos.</summary>
	public FVector MinPos;
	///<summary>Coordinates will be clamped to MinPos and MaxPos.</summary>
	public FVector MaxPos;
}

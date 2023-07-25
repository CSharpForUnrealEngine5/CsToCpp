#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/Filtering/NetObjectGridFilter.h")]
public partial class UNetObjectGridFilterConfig : UNetObjectFilterConfig {
// NetObjectGridFilterConfig
	public uint ViewPosRelevancyFrameCount;
	public float CellSizeX;
	public float CellSizeY;
	public float MaxCullDistance;
	public float DefaultCullDistance;
	public FVector MinPos;
	public FVector MaxPos;
}

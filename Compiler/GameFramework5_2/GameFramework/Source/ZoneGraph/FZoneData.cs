#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneData {
// ZoneData
	public int BoundaryPointsBegin;
	public int BoundaryPointsEnd;
	public int LanesBegin;
	public int LanesEnd;
	public FBox Bounds;
	public FZoneGraphTagMask Tags;
}

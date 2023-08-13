namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneData {
	public int BoundaryPointsBegin;
	public int BoundaryPointsEnd;
	public int LanesBegin;
	public int LanesEnd;
	public FBox Bounds;
	public FZoneGraphTagMask Tags;
}

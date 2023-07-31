#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes single lane.</summary>
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneLaneDesc {
	public float Width;
	public EZoneLaneDirection Direction;
	public FZoneGraphTagMask Tags;
}

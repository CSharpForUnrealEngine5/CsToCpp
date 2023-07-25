#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
///<summary>Filter passes if any of the 'AnyTags', and all of the 'AllTags', and none of the 'NotTags' are present.</summary>
public partial struct FZoneGraphTagFilter {
// ZoneGraphTagFilter
	public FZoneGraphTagMask AnyTags;
	public FZoneGraphTagMask AllTags;
	public FZoneGraphTagMask NotTags;
}

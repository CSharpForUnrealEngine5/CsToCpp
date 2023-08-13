namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter passes if any of the &#39;AnyTags&#39;, and all of the &#39;AllTags&#39;, and none of the &#39;NotTags&#39; are present.</summary>
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneGraphTagFilter {
	public FZoneGraphTagMask AnyTags;
	public FZoneGraphTagMask AllTags;
	public FZoneGraphTagMask NotTags;
}

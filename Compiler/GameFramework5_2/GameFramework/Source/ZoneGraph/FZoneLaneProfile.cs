#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
///<summary>Describes template of multiple parallel lanes, created in settings.</summary>
public partial struct FZoneLaneProfile {
// ZoneLaneProfile
	public string Name;
	public FGuid ID;
	public TArray<FZoneLaneDesc> Lanes;
}

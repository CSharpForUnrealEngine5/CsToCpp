#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes template of multiple parallel lanes, created in settings.</summary>
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneLaneProfile {
	public string Name;
	public FGuid ID;
	public TArray<FZoneLaneDesc> Lanes;
}

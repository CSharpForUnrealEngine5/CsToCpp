namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes template of multiple parallel lanes, created in settings.</summary>
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneLaneProfile {
	public FName Name;
	public FGuid ID;
	public TArray<FZoneLaneDesc> Lanes;
}

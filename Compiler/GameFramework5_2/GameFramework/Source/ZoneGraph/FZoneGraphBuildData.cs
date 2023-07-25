#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphBuilder.h")]
///<summary>Build time data, can be used to map things between editor representation and baked data.</summary>
public partial struct FZoneGraphBuildData {
// ZoneGraphBuildData
	public TMap<UZoneShapeComponent,FZoneShapeComponentBuildData> ZoneShapeComponentBuildData;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Build time data, can be used to map things between editor representation and baked data.</summary>
[CppInclude("ZoneGraphBuilder.h")]
public partial struct FZoneGraphBuildData {
	public TMap<UZoneShapeComponent,FZoneShapeComponentBuildData> ZoneShapeComponentBuildData;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphBuilder.h")]
public partial struct FZoneGraphBuilder {
// ZoneGraphBuilder
	public TArray<FZoneGraphBuilderRegisteredComponent> ShapeComponents;
	public TArray<int> ShapeComponentsFreeList;
	public TMap<UZoneShapeComponent,int> ShapeComponentToIndex;
	public FZoneGraphBuildData BuildData;
}

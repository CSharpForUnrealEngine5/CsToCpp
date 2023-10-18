namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphBuilder.h")]
public partial struct FZoneGraphBuilder {
	public TArray<FZoneGraphBuilderRegisteredComponent> ShapeComponents;
	public TArray<int> ShapeComponentsFreeList;
	public TMap<UZoneShapeComponent,int> ShapeComponentToIndex;
	public FZoneGraphBuildData BuildData;
}

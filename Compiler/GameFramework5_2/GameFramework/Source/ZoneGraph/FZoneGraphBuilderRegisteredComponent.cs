namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>5 levels of hierarchy, 4 ration between levels (biggest bucket 4^5 = 1024 cells)</summary>
[CppInclude("ZoneGraphBuilder.h")]
public partial struct FZoneGraphBuilderRegisteredComponent {
	public UZoneShapeComponent Component;
	public uint ShapeHash;
}

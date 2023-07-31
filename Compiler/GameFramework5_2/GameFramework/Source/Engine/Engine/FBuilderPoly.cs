#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Internal state, not accessible to script.</summary>
[CppInclude("Engine/BrushBuilder.h")]
public partial struct FBuilderPoly {
	public TArray<int> VertexIndices;
	public int Direction;
	public string ItemName;
	public int PolyFlags;
}

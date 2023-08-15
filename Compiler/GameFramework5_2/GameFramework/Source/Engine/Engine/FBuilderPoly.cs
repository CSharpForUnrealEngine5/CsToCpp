namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Internal state, not accessible to script.</summary>
[CppInclude("Engine/BrushBuilder.h")]
public partial struct FBuilderPoly {
	public TArray<int> VertexIndices;
	public int Direction;
	public FName ItemName;
	public int PolyFlags;
}

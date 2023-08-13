namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SpriteEditorOnlyTypes.h")]
public partial struct FSpriteGeometryCollection {
	public TArray<FSpriteGeometryShape> Shapes;
	public ESpritePolygonMode GeometryType;
	public int PixelsPerSubdivisionX;
	public int PixelsPerSubdivisionY;
	public bool bAvoidVertexMerging;
	public float AlphaThreshold;
	public float DetailAmount;
	public float SimplifyEpsilon;
}

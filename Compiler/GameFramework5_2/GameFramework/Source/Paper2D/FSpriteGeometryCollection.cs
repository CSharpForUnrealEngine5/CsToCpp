#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SpriteEditorOnlyTypes.h")]
public partial struct FSpriteGeometryCollection {
// SpriteGeometryCollection
	public TArray<FSpriteGeometryShape> Shapes;
	public ESpritePolygonMode GeometryType;
	public int PixelsPerSubdivisionX;
	public int PixelsPerSubdivisionY;
	public bool bAvoidVertexMerging;
	public float AlphaThreshold;
	public float DetailAmount;
	public float SimplifyEpsilon;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single piece of geometry (e.g., a polygon which may be convex or concave, a box, or a circle)</summary>
[CppInclude("SpriteEditorOnlyTypes.h")]
public partial struct FSpriteGeometryShape {
	public ESpriteShapeType ShapeType;
	public TArray<FVector2D> Vertices;
	public FVector2D BoxSize;
	public FVector2D BoxPosition;
	public float Rotation;
	public bool bNegativeWinding;
}

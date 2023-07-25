#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshPaintSettings.h")]
public partial class UPaintBrushSettings : UObject {
// PaintBrushSettings
	public float BrushRadius;
	public float BrushStrength;
	public float BrushFalloffAmount;
	public bool bEnableFlow;
	public bool bOnlyFrontFacingTriangles;
	public EMeshPaintColorViewMode ColorViewMode;
}

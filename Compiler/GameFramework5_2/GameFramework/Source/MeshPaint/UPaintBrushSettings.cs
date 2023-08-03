#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshPaintSettings.h")]
public partial class UPaintBrushSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Radius of the Brush used for Painting</summary>
	public float BrushRadius;
	///<summary>Strength of the brush (0.0 - 1.0)</summary>
	public float BrushStrength;
	///<summary>Amount of falloff to apply (0.0 - 1.0)</summary>
	public float BrushFalloffAmount;
	///<summary>Enables &quot;Flow&quot; painting where paint is continually applied from the brush every tick</summary>
	public bool bEnableFlow;
	///<summary>Whether back-facing triangles should be ignored</summary>
	public bool bOnlyFrontFacingTriangles;
	///<summary>Color view mode used to display Vertex Colors</summary>
	public EMeshPaintColorViewMode ColorViewMode;
}

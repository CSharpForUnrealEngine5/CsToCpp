namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component for rendering an arbitrary assortment of triangles. Suitable, for instance, for rendering highlighted faces.</summary>
[CppInclude("Drawing/TriangleSetComponent.h")]
public partial class UTriangleSetComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Bounds</summary>
	public FBoxSphereBounds Bounds;
	///<summary>bBoundsDirty</summary>
	public bool bBoundsDirty;
}

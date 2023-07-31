#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/LineSetComponent.h")]
public partial class ULineSetComponent : UMeshComponent {
	///<summary>LineMaterial</summary>
	public UMaterialInterface LineMaterial;
	///<summary>Bounds</summary>
	public FBoxSphereBounds Bounds;
	///<summary>bBoundsDirty</summary>
	public bool bBoundsDirty;
}

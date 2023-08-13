namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/LineSetComponent.h")]
public partial class ULineSetComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>LineMaterial</summary>
	public UMaterialInterface LineMaterial;
	///<summary>Bounds</summary>
	public FBoxSphereBounds Bounds;
	///<summary>bBoundsDirty</summary>
	public bool bBoundsDirty;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Experimental - Bake transform of input meshes</summary>
[CppInclude("DataprepGeometryOperations.h")]
public partial class UDataprepBakeTransformOperation : UDataprepEditingOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Bake rotation</summary>
	public bool bBakeRotation;
	///<summary>Bake scale</summary>
	public EBakeScaleMethod BakeScale;
	///<summary>Recenter pivot after baking transform</summary>
	public bool bRecenterPivot;
}

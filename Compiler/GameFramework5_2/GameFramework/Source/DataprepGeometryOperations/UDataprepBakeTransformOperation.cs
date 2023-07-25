#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepGeometryOperations.h")]
///<summary>Experimental - Bake transform of input meshes</summary>
public partial class UDataprepBakeTransformOperation : UDataprepEditingOperation {
// DataprepBakeTransformOperation
	public bool bBakeRotation;
	public EBakeScaleMethod BakeScale;
	public bool bRecenterPivot;
}

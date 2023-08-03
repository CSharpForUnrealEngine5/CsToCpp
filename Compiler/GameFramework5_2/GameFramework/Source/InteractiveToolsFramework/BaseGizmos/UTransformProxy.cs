#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTransformProxy is used to transform a set of sub-objects. An internal</summary>
[CppInclude("BaseGizmos/TransformProxy.h")]
public partial class UTransformProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true, relative rotation of shared transform is applied to objects before relative translation (ie they rotate in place)</summary>
	public bool bRotatePerObject;
	///<summary>If true, then on SetTransform() the components are not moved, and their local transforms are recalculated</summary>
	public bool bSetPivotMode;
	///<summary>The main transform</summary>
	public FTransform SharedTransform;
	///<summary>The main transform</summary>
	public FTransform InitialSharedTransform;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug draw parameters for an Axis given a transform</summary>
[CppInclude("Units/Debug/RigUnit_VisualDebug.h")]
public partial struct FRigUnit_VisualDebugTransformItemSpace {
	public FTransform Value;
	public bool bEnabled;
	public float Thickness;
	public float Scale;
	public FRigElementKey Space;
}

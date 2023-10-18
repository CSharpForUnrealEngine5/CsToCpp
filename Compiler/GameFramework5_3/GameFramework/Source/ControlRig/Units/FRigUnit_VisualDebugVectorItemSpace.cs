namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug draw parameters for a Point or Vector given a vector</summary>
[CppInclude("Units/Debug/RigUnit_VisualDebug.h")]
public partial struct FRigUnit_VisualDebugVectorItemSpace {
	public FVector Value;
	public bool bEnabled;
	public ERigUnitVisualDebugPointMode Mode;
	public FLinearColor Color;
	public float Thickness;
	public float Scale;
	public FRigElementKey Space;
}

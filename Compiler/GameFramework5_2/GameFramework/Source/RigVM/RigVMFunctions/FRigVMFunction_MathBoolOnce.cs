namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true once the first time this node is hit</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathBool.h")]
public partial struct FRigVMFunction_MathBoolOnce {
	public float Duration;
	public bool Result;
	public bool LastValue;
	public float TimeLeft;
}

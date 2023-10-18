namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts frames to seconds based on the current frame rate</summary>
[CppInclude("RigVMFunctions/Animation/RigVMFunction_TimeConversion.h")]
public partial struct FRigVMFunction_FramesToSeconds {
	public float Frames;
	public float Seconds;
}

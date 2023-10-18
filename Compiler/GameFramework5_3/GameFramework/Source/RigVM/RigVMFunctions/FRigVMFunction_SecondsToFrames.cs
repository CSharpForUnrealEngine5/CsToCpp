namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts seconds to frames based on the current frame rate</summary>
[CppInclude("RigVMFunctions/Animation/RigVMFunction_TimeConversion.h")]
public partial struct FRigVMFunction_SecondsToFrames {
	public float Seconds;
	public float Frames;
}

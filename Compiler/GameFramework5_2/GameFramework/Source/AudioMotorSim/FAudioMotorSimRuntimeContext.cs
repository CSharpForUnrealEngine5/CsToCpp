#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMotorSimTypes.h")]
///<summary>properties that represent the current state of the motor sim, and persist between updates</summary>
public partial struct FAudioMotorSimRuntimeContext {
// AudioMotorSimRuntimeContext
	public bool bShifting;
	public int Gear;
	public float Rpm;
	public float Volume;
	public float Pitch;
}

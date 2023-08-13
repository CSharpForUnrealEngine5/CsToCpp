namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>properties that represent the current state of the motor sim, and persist between updates</summary>
[CppInclude("AudioMotorSimTypes.h")]
public partial struct FAudioMotorSimRuntimeContext {
	public bool bShifting;
	public int Gear;
	public float Rpm;
	public float Volume;
	public float Pitch;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAudioMotorSim.h")]
public partial class UAudioMotorSim : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Use to reset any state that might be desired. Will be called automatically if the entire MotorSim is Reset, or call it manually</summary>
	public virtual void Reset() {}
}

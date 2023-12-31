namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAudioMotorSim.h")]
public partial class UAudioMotorSimComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Called every tick that this component is being updated. Use &quot;Set Members in Struct&quot; to update values for future components in the chain. The return value does nothing.</summary>
	public bool BP_Update(FAudioMotorSimInputContext Input,FAudioMotorSimRuntimeContext RuntimeInfo) { return default; }
	///<summary>Use to reset any state that might be desired. Will be called automatically if the entire MotorSim is Reset, or call it manually</summary>
	public void BP_Reset() {}
}

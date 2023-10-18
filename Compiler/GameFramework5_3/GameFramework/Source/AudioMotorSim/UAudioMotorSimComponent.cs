namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAudioMotorSim.h")]
public partial class UAudioMotorSimComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Called every tick that this component is being updated. Use &quot;Set Members in Struct&quot; to update values for future components in the chain. The return value does nothing.</summary>
	public bool BP_Update(FAudioMotorSimInputContext Input,FAudioMotorSimRuntimeContext RuntimeInfo) { return default; }
	///<summary>Called when something Resets this component</summary>
	public void BP_Reset() {}
	///<summary>Input data after running this component</summary>
	public FAudioMotorSimInputContext CachedInput;
	///<summary>runtime info after running this component</summary>
	public FAudioMotorSimRuntimeContext CachedRuntimeInfo;
}

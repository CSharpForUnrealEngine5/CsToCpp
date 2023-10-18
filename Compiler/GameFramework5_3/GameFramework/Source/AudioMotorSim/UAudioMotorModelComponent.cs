namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMotorModelComponent.h")]
public partial class UAudioMotorModelComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SimComponents</summary>
	public TArray<FMotorSimEntry> SimComponents;
	///<summary>AudioComponents</summary>
	public TArray<object /*AudioComponents*/> AudioComponents;
	///<summary>Update</summary>
	public virtual void Update(FAudioMotorSimInputContext Input) {}
	///<summary>Reset</summary>
	public virtual void Reset() {}
	///<summary>StartOutput</summary>
	public virtual void StartOutput() {}
	///<summary>StopOutput</summary>
	public virtual void StopOutput() {}
	///<summary>AddMotorAudioComponent</summary>
	public void AddMotorAudioComponent(object /*InComponent*/ InComponent) {}
	///<summary>RemoveMotorAudioComponent</summary>
	public void RemoveMotorAudioComponent(object /*InComponent*/ InComponent) {}
	///<summary>AddMotorSimComponent</summary>
	public void AddMotorSimComponent(object /*InComponent*/ InComponent,int SortOrder/*=0*/) {}
	///<summary>RemoveMotorSimComponent</summary>
	public void RemoveMotorSimComponent(object /*InComponent*/ InComponent) {}
	///<summary>GetRpm</summary>
	public float GetRpm() { return default; }
	///<summary>GetGear</summary>
	public int GetGear() { return default; }
	///<summary>GetRuntimeInfo</summary>
	public FAudioMotorSimRuntimeContext GetRuntimeInfo() { return default; }
	///<summary>GetCachedInputData</summary>
	public FAudioMotorSimInputContext GetCachedInputData() { return default; }
}

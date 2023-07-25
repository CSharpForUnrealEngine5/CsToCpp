#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMotorModelComponent.h")]
public partial class UAudioMotorModelComponent : UActorComponent {
// AudioMotorModelComponent
	public TArray<FMotorSimEntry> SimComponents;
	public TArray<object /*AudioComponents*/> AudioComponents;
	public void Update(FAudioMotorSimInputContext Input) {}
	public void Reset() {}
	public void StartOutput() {}
	public void StopOutput() {}
	public void AddMotorAudioComponent(object /*InComponent*/ InComponent) {}
	public void RemoveMotorAudioComponent(object /*InComponent*/ InComponent) {}
	public void AddMotorSimComponent(object /*InComponent*/ InComponent,int SortOrder/*=0*/) {}
	public void RemoveMotorSimComponent(object /*InComponent*/ InComponent) {}
	public float GetRpm() { return default; }
	public int GetGear() { return default; }
	public FAudioMotorSimRuntimeContext GetRuntimeInfo() { return default; }
	public FAudioMotorSimInputContext GetCachedInputData() { return default; }
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/AsyncPhysicsInputComponent.h")]
public partial class UAsyncPhysicsInputComponent : UActorComponent {
// AsyncPhysicsInputComponent
	public void ServerRPCBufferInput(UObject AsyncPhysicsData) {}
	public UObject GetDataToWrite() { return default; }
	public UObject GetDataToConsume() { return default; }
	public UClass DataClass;
	public TArray<UAsyncPhysicsData> BufferedData;
	public UAsyncPhysicsData DataToConsume;
	public UAsyncPhysicsData DataToWrite;
}

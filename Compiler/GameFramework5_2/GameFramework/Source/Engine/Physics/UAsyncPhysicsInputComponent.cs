namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/AsyncPhysicsInputComponent.h")]
public partial class UAsyncPhysicsInputComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>ServerRPCBufferInput</summary>
	public void ServerRPCBufferInput(UAsyncPhysicsData AsyncPhysicsData) {}
	///<summary>Get the async physics data to write to. This data will make its way to the async physics tick on client and server. Should not be called from async tick</summary>
	public UAsyncPhysicsData GetDataToWrite() { return default; }
	///<summary>Get the async physics data to execute logic off of. This data should not be modified and will NOT make its way back. Should be called from async tick</summary>
	public UAsyncPhysicsData GetDataToConsume() { return default; }
	///<summary>DataClass</summary>
	public UClass DataClass;
	///<summary>BufferedData</summary>
	public TArray<UAsyncPhysicsData> BufferedData;
	///<summary>DataToConsume</summary>
	public UAsyncPhysicsData DataToConsume;
	///<summary>DataToWrite</summary>
	public UAsyncPhysicsData DataToWrite;
}

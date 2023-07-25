#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/AsyncPhysicsData.h")]
///<summary>The base class for async physics data. Inherit from this to create custom data for async physics tick.</summary>
public partial class UAsyncPhysicsData : UObject {
// AsyncPhysicsData
	public int ServerFrame;
	public int ReplicationRedundancy;
}

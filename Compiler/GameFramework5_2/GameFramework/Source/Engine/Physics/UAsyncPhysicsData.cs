#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class for async physics data. Inherit from this to create custom data for async physics tick.</summary>
[CppInclude("Physics/AsyncPhysicsData.h")]
public partial class UAsyncPhysicsData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ServerFrame</summary>
	public int ServerFrame;
	///<summary>Determines how many times we redundantly send data to server. The higher this number the less packet loss, but more bandwidth is used</summary>
	public int ReplicationRedundancy;
}

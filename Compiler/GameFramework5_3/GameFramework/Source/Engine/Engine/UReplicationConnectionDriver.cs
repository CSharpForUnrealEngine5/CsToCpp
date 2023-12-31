namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class/interface for replication extension that is per connection. It is up to the replication driver to create and associate these with a UNetConnection</summary>
[CppInclude("Engine/ReplicationDriver.h")]
public partial class UReplicationConnectionDriver : UObject {
	public static UClass StaticClass() {return default;}
}

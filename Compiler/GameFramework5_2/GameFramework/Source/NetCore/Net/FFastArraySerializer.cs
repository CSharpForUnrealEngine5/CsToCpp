#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/Serialization/FastArraySerializer.h")]
///<summary>Base struct for wrapping the array used in Fast TArray Replication</summary>
public partial struct FFastArraySerializer {
// FastArraySerializer
	public int ArrayReplicationKey;
	public EFastArraySerializerDeltaFlags DeltaFlags;
}

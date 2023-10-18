namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct for wrapping the array used in Fast TArray Replication</summary>
[CppInclude("Net/Serialization/FastArraySerializer.h")]
public partial struct FFastArraySerializer {
	public int ArrayReplicationKey;
	public EFastArraySerializerDeltaFlags DeltaFlags;
}

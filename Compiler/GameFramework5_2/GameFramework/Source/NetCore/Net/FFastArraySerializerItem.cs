#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/Serialization/FastArraySerializer.h")]
///<summary>Base struct for items using Fast TArray Replication</summary>
public partial struct FFastArraySerializerItem {
// FastArraySerializerItem
	public int ReplicationID;
	public int ReplicationKey;
	public int MostRecentArrayReplicationKey;
}

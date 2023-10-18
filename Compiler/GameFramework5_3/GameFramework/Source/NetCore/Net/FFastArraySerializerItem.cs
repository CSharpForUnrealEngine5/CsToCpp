namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct for items using Fast TArray Replication</summary>
[CppInclude("Net/Serialization/FastArraySerializer.h")]
public partial struct FFastArraySerializerItem {
	public int ReplicationID;
	public int ReplicationKey;
	public int MostRecentArrayReplicationKey;
}

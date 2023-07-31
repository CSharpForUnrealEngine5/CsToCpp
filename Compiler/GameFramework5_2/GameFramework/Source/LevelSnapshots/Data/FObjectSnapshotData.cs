#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Shared data all saved objects in Level Snapshots have.</summary>
[CppInclude("Data/ObjectSnapshotData.h")]
public partial struct FObjectSnapshotData {
	public TArray<byte> SerializedData;
	public ulong ObjectFlags;
}

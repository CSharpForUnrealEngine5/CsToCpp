#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ObjectSnapshotData.h")]
///<summary>Shared data all saved objects in Level Snapshots have.</summary>
public partial struct FObjectSnapshotData {
// ObjectSnapshotData
	public TArray<byte> SerializedData;
	public ulong ObjectFlags;
}

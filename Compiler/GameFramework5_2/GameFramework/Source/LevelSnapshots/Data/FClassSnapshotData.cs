#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ClassSnapshotData.h")]
///<summary>Holds class information for a specific use of a class. Usually it holds the class archetype.</summary>
public partial struct FClassSnapshotData {
// ClassSnapshotData
	public FSoftClassPath ClassPath;
	public ulong ClassFlags;
	public ESnapshotClassFlags SnapshotFlags;
}

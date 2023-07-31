#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds class information for a specific use of a class. Usually it holds the class archetype.</summary>
[CppInclude("Data/ClassSnapshotData.h")]
public partial struct FClassSnapshotData {
	public FSoftClassPath ClassPath;
	public ulong ClassFlags;
	public ESnapshotClassFlags SnapshotFlags;
}

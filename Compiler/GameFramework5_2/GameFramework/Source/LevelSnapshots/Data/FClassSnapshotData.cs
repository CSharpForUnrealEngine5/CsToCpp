namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds class information for a specific use of a class. Usually it holds the class archetype.</summary>
[CppInclude("Data/ClassSnapshotData.h")]
public partial struct FClassSnapshotData {
	public FSoftClassPath ClassPath;
	public ulong ClassFlags;
	public ESnapshotClassFlags SnapshotFlags;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data saved for subobjects, such as components.</summary>
[CppInclude("Data/SubobjectSnapshotData.h")]
public partial struct FSubobjectSnapshotData {
	public int OuterIndex;
	public FSoftClassPath Class_DEPRECATED;
	public int ClassIndex;
	public bool bWasSkippedClass;
}

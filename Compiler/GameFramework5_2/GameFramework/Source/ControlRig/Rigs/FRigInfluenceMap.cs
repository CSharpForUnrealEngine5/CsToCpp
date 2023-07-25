#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigInfluenceMap.h")]
public partial struct FRigInfluenceMap {
// RigInfluenceMap
	public string EventName;
	public TArray<FRigInfluenceEntry> Entries;
	public TMap<FRigElementKey,int> KeyToIndex;
}

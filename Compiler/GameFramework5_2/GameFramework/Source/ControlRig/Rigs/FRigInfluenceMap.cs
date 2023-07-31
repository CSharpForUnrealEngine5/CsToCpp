#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigInfluenceMap.h")]
public partial struct FRigInfluenceMap {
	public string EventName;
	public TArray<FRigInfluenceEntry> Entries;
	public TMap<FRigElementKey,int> KeyToIndex;
}

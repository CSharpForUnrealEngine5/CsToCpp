namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigInfluenceMap.h")]
public partial struct FRigInfluenceMap {
	public FName EventName;
	public TArray<FRigInfluenceEntry> Entries;
	public TMap<FRigElementKey,int> KeyToIndex;
}

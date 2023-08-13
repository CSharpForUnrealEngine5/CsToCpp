namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigInfluenceMap.h")]
public partial struct FRigInfluenceMapPerEvent {
	public TArray<FRigInfluenceMap> Maps;
	public TMap<string,int> EventToIndex;
}

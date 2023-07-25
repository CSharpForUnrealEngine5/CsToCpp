#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigInfluenceMap.h")]
public partial struct FRigInfluenceMapPerEvent {
// RigInfluenceMapPerEvent
	public TArray<FRigInfluenceMap> Maps;
	public TMap<string,int> EventToIndex;
}

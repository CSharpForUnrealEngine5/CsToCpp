#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGWorldData.h")]
public partial struct FPCGWorldCommonQueryParams {
// PCGWorldCommonQueryParams
	public bool bIgnorePCGHits;
	public bool bIgnoreSelfHits;
	public byte CollisionChannel;
	public bool bTraceComplex;
	public EPCGWorldQueryFilterByTag ActorTagFilter;
	public string ActorTagsList;
	public bool bIgnoreLandscapeHits;
	public TSet<string> ParsedActorTagsList;
}

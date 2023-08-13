namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGWorldData.h")]
public partial struct FPCGWorldCommonQueryParams {
	public bool bIgnorePCGHits;
	public bool bIgnoreSelfHits;
	public ECollisionChannel CollisionChannel;
	public bool bTraceComplex;
	public EPCGWorldQueryFilterByTag ActorTagFilter;
	public string ActorTagsList;
	public bool bIgnoreLandscapeHits;
	public TSet<string> ParsedActorTagsList;
}

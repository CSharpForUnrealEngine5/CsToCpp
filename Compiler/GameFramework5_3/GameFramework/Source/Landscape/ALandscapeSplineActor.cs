namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplineActor.h")]
public partial class ALandscapeSplineActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Guid for LandscapeInfo *</summary>
	public FGuid LandscapeGuid;
	///<summary>Landscape *</summary>
	public ALandscape LandscapeActor;
}

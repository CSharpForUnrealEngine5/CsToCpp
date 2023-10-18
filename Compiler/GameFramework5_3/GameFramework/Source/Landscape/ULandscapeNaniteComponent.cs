namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeNaniteComponent.h")]
public partial class ULandscapeNaniteComponent : UStaticMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The landscape proxy identity this Nanite representation was generated for</summary>
	public FGuid ProxyContentId;
	///<summary>bEnabled</summary>
	public bool bEnabled;
}

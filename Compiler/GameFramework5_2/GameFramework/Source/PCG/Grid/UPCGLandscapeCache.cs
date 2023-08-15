namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Grid/PCGLandscapeCache.h")]
public partial class UPCGLandscapeCache : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>TODO: separate by landscape</summary>
	public TSet<FName> CachedLayerNames;
}

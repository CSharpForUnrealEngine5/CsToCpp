namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeMeshProxyComponent.h")]
public partial class ULandscapeMeshProxyComponent : UStaticMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The landscape this proxy was generated for</summary>
	public FGuid LandscapeGuid;
	///<summary>The components this proxy was generated for</summary>
	public TArray<FIntPoint> ProxyComponentBases;
	///<summary>LOD level proxy was generated for</summary>
	public short ProxyLOD;
	///<summary>LODGroupKey</summary>
	public uint LODGroupKey;
}

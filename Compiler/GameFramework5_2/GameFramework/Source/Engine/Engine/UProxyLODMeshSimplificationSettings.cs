namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Controls the system used to generate proxy LODs with merged meshes (i.e. the HLOD system).</summary>
[CppInclude("Engine/ProxyLODMeshSimplificationSettings.h")]
public partial class UProxyLODMeshSimplificationSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Mesh reduction plugin to use when simplifying mesh geometry for Hierarchical LOD</summary>
	public string ProxyLODMeshReductionModuleName;
}

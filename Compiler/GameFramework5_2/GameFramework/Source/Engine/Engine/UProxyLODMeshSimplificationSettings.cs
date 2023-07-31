#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Controls the system used to generate proxy LODs with merged meshes (i.e. the HLOD system).</summary>
[CppInclude("Engine/ProxyLODMeshSimplificationSettings.h")]
public partial class UProxyLODMeshSimplificationSettings : UDeveloperSettings {
	///<summary>Mesh reduction plugin to use when simplifying mesh geometry for Hierarchical LOD</summary>
	public string ProxyLODMeshReductionModuleName;
}

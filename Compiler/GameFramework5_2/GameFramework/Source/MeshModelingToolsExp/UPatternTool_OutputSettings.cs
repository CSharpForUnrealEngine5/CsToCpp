#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Output Settings for the Pattern Tool</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternTool_OutputSettings : UInteractiveToolPropertySet {
	///<summary>Emit a separate Actor for each pattern element</summary>
	public bool bSeparateActors;
	///<summary>Emit StaticMesh pattern elements as DynamicMeshes</summary>
	public bool bConvertToDynamic;
	///<summary>Create InstancedStaticMeshComponents instead multiple StaticMeshComponents, for StaticMesh pattern elements</summary>
	public bool bCreateISMCs;
	///<summary>internal, used to control state of Instance settings</summary>
	public bool bHaveStaticMeshes;
}

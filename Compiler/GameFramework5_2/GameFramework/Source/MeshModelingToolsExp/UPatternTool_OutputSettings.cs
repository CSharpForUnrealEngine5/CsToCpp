namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Output Settings for the Pattern Tool</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternTool_OutputSettings : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Emit a separate Actor for each pattern element</summary>
	public bool bSeparateActors;
	///<summary>Emit StaticMesh pattern elements as DynamicMeshes</summary>
	public bool bConvertToDynamic;
	///<summary>Create InstancedStaticMeshComponents instead multiple StaticMeshComponents, for StaticMesh pattern elements</summary>
	public bool bCreateISMCs;
	///<summary>internal, used to control state of Instance settings</summary>
	public bool bHaveStaticMeshes;
}

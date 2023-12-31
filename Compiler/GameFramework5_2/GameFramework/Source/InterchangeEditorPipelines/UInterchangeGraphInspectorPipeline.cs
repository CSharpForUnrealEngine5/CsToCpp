namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This pipeline is the generic pipeline option for all meshes type and should be call before specialized Mesh pipeline (like generic static mesh or skeletal mesh pipelines)</summary>
[CppInclude("InterchangeGraphInspectorPipeline.h")]
public partial class UInterchangeGraphInspectorPipeline : UInterchangePipelineBase {
	public static UClass StaticClass() {return default;}
}

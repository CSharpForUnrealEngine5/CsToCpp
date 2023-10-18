namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericScenesPipeline.h")]
public partial class UInterchangeGenericLevelPipeline : UInterchangePipelineBase {
	public static UClass StaticClass() {return default;}
	///<summary>Allow user to choose the re-import strategy when re-importing into level.</summary>
	public EReimportStrategyFlags ReimportPropertyStrategy;
	///<summary>Enables or not the deletion of actors which were not part of the translation when re-importing into level.</summary>
	public bool bDeleteMissingActors;
	///<summary>Enables or not spawning actors which were deleted in the editor prior to a reimport.</summary>
	public bool bForceReimportDeletedActors;
	///<summary>Enables or not re-creating assets which were deleted in the editor prior to a reimport into level.</summary>
	public bool bForceReimportDeletedAssets;
	///<summary>Enables or not the deletion of assets which were not part of the translation when re-importing into level.</summary>
	public bool bDeleteMissingAssets;
	///<summary>Disable this option to not convert Standard(Perspective) to Physical Cameras</summary>
	public bool bUsePhysicalInsteadOfStandardPerspectiveCamera;
}

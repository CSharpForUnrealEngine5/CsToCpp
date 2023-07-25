#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeProjectSettings.h")]
public partial class UInterchangeProjectSettings : UDeveloperSettings {
// InterchangeProjectSettings
	public FInterchangeContentImportSettings ContentImportSettings;
	public FInterchangeImportSettings SceneImportSettings;
	public TSoftObjectPtr<UClass> FilePickerClass;
	public bool bStaticMeshUseSmoothEdgesIfSmoothingInformationIsMissing;
	public TSoftObjectPtr<UClass> GenericPipelineClass;
}

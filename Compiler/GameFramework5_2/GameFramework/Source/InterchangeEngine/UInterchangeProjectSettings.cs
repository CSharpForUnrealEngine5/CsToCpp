#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeProjectSettings.h")]
public partial class UInterchangeProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Settings used when importing into the content browser.</summary>
	public FInterchangeContentImportSettings ContentImportSettings;
	///<summary>Settings used when importing into a level.</summary>
	public FInterchangeImportSettings SceneImportSettings;
	///<summary>This tells interchange which file picker class to construct when we need to choose a file for a source.</summary>
	public TSoftObjectPtr<UClass> FilePickerClass;
	///<summary>If checked, interchange translators and legacy importer will default static mesh geometry to smooth edge when the smoothing information is missing.</summary>
	public bool bStaticMeshUseSmoothEdgesIfSmoothingInformationIsMissing;
	///<summary>This tells interchange which is the pipeline class to use when editor tools want to import or reimport tools with bake settings.</summary>
	public TSoftObjectPtr<UClass> GenericPipelineClass;
}

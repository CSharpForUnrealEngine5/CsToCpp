#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Data for specifying a usable plugin template.</summary>
[CppInclude("GameFeaturesEditorSettings.h")]
public partial struct FPluginTemplateData {
	public FDirectoryPath Path;
	public string Label;
	public string Description;
	public UClass DefaultGameFeatureDataClass;
	public string DefaultGameFeatureDataName;
	public bool bIsEnabledByDefault;
}

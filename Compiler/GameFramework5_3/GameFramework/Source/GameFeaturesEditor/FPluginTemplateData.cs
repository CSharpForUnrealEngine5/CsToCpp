namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Data for specifying a usable plugin template.</summary>
[CppInclude("GameFeaturesEditorSettings.h")]
public partial struct FPluginTemplateData {
	public FDirectoryPath Path;
	public FText Label;
	public FText Description;
	public string DefaultSubfolder;
	public UClass DefaultGameFeatureDataClass;
	public string DefaultGameFeatureDataName;
	public bool bIsEnabledByDefault;
}

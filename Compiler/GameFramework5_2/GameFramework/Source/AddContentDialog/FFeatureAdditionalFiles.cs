namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that defines a shared feature pack resource.</summary>
[CppInclude("FeaturePackContentSource.h")]
public partial struct FFeatureAdditionalFiles {
	public string DestinationFilesFolder;
	public TArray<string> AdditionalFilesList;
}

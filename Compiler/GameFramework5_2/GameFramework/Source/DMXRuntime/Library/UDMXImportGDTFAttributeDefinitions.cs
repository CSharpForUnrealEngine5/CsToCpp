namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial class UDMXImportGDTFAttributeDefinitions : UDMXImportAttributeDefinitions {
	public static UClass StaticClass() {return default;}
	///<summary>ActivationGroups</summary>
	public TArray<FDMXImportGDTFActivationGroup> ActivationGroups;
	///<summary>FeatureGroups</summary>
	public TArray<FDMXImportGDTFFeatureGroup> FeatureGroups;
	///<summary>Attributes</summary>
	public TArray<FDMXImportGDTFAttribute> Attributes;
}

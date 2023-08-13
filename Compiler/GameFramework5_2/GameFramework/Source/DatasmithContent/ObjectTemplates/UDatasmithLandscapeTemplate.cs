namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithLandscapeTemplate.h")]
public partial class UDatasmithLandscapeTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>LandscapeMaterial</summary>
	public UMaterialInterface LandscapeMaterial;
	///<summary>StaticLightingLOD</summary>
	public int StaticLightingLOD;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithSkyLightComponentTemplate.h")]
public partial class UDatasmithSkyLightComponentTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>SourceType</summary>
	public ESkyLightSourceType SourceType;
	///<summary>CubemapResolution</summary>
	public int CubemapResolution;
	///<summary>Cubemap</summary>
	public UTextureCube Cubemap;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithPointLightComponentTemplate.h")]
public partial class UDatasmithPointLightComponentTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>IntensityUnits</summary>
	public ELightUnits IntensityUnits;
	///<summary>SourceRadius</summary>
	public float SourceRadius;
	///<summary>SourceLength</summary>
	public float SourceLength;
	///<summary>AttenuationRadius</summary>
	public float AttenuationRadius;
}

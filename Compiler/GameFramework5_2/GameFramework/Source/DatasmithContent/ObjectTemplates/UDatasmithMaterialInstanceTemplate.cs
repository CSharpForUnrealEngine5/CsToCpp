namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Applies material instance data to a material instance if it hasn&#39;t changed since the last time we&#39;ve applied a template.</summary>
[CppInclude("ObjectTemplates/DatasmithMaterialInstanceTemplate.h")]
public partial class UDatasmithMaterialInstanceTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>ParentMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> ParentMaterial;
	///<summary>ScalarParameterValues</summary>
	public TMap<string,float> ScalarParameterValues;
	///<summary>VectorParameterValues</summary>
	public TMap<string,FLinearColor> VectorParameterValues;
	///<summary>TextureParameterValues</summary>
	public TMap<string,TSoftObjectPtr<UTexture>> TextureParameterValues;
	///<summary>StaticParameters</summary>
	public FDatasmithStaticParameterSetTemplate StaticParameters;
}

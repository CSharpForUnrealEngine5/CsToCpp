namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithDecalComponentTemplate.h")]
public partial class UDatasmithDecalComponentTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>SortOrder</summary>
	public int SortOrder;
	///<summary>DecalSize</summary>
	public FVector DecalSize;
	///<summary>Material</summary>
	public UMaterialInterface Material;
}

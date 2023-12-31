namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TemplateProjectDefs.h")]
public partial class UTemplateCategories : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array of all categories specified in this location.</summary>
	public TArray<FTemplateCategoryDef> Categories;
}

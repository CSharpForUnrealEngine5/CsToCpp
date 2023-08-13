namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TemplateProjectDefs.h")]
public partial struct FTemplateCategoryDef {
	public string Key;
	public TArray<FLocalizedTemplateString> LocalizedDisplayNames;
	public TArray<FLocalizedTemplateString> LocalizedDescriptions;
	public string Icon;
	public bool IsMajorCategory;
}

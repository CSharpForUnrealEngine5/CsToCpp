namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Minimal descriptor needed to generate a localization target for UGC localization.</summary>
[CppInclude("UserGeneratedContentLocalization.h")]
public partial struct FUserGeneratedContentLocalizationDescriptor {
	public string NativeCulture;
	public TArray<string> CulturesToGenerate;
	public EPortableObjectFormat PoFormat;
}

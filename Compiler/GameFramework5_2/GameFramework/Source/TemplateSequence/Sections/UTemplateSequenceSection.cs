namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines the section for a template sequence track.</summary>
[CppInclude("Sections/TemplateSequenceSection.h")]
public partial class UTemplateSequenceSection : UMovieSceneSubSection {
	public static UClass StaticClass() {return default;}
	///<summary>PropertyScales</summary>
	public TArray<FTemplateSectionPropertyScale> PropertyScales;
}

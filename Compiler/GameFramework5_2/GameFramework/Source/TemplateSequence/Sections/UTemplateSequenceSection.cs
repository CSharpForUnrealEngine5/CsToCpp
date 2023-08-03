#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines the section for a template sequence track.</summary>
[CppInclude("Sections/TemplateSequenceSection.h")]
public partial class UTemplateSequenceSection : UMovieSceneSubSection {
	public static UClass StaticClass() {return default;}
	///<summary>PropertyScales</summary>
	public TArray<FTemplateSectionPropertyScale> PropertyScales;
}

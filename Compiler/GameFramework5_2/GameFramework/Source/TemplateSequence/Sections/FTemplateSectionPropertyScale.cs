namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a property scaling for a template sequence.</summary>
[CppInclude("Sections/TemplateSequenceSection.h")]
public partial struct FTemplateSectionPropertyScale {
	public FGuid ObjectBinding;
	public FMovieScenePropertyBinding PropertyBinding;
	public ETemplateSectionPropertyScaleType PropertyScaleType;
	public FMovieSceneFloatChannel FloatChannel;
}

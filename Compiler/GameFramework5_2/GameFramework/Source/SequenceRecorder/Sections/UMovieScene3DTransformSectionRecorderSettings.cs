#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieScene3DTransformSectionRecorderSettings.h")]
public partial class UMovieScene3DTransformSectionRecorderSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to record actor transforms. This can be useful if you want the actors to end up in specific locations after the sequence.</summary>
	public bool bRecordTransforms;
}

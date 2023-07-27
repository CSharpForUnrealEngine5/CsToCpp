#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieScene3DConstraintSection.h")]
///<summary>Base class for 3D constraint section</summary>
public partial class UMovieScene3DConstraintSection : UMovieSceneSection {
// MovieScene3DConstraintSection
	public  FMovieSceneObjectBindingID GetConstraintBindingID() { return default; }
	public  void SetConstraintBindingID(FMovieSceneObjectBindingID InConstraintBindingID) {}
	public FGuid ConstraintId_DEPRECATED;
	public FMovieSceneObjectBindingID ConstraintBindingID;
}

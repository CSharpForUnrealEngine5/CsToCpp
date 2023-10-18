namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for 3D constraint section</summary>
[CppInclude("Sections/MovieScene3DConstraintSection.h")]
public partial class UMovieScene3DConstraintSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the constraint binding for this Constraint section</summary>
	public FMovieSceneObjectBindingID GetConstraintBindingID() { return default; }
	///<summary>Sets the constraint binding for this Constraint section</summary>
	public void SetConstraintBindingID(FMovieSceneObjectBindingID InConstraintBindingID) {}
	///<summary>The possessable guid that this constraint uses</summary>
	public FGuid ConstraintId_DEPRECATED;
	///<summary>The constraint binding that this movie Constraint uses</summary>
	public FMovieSceneObjectBindingID ConstraintBindingID;
}

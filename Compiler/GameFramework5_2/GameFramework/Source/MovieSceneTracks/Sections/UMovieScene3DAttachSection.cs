#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieScene3DAttachSection.h")]
///<summary>A 3D Attach section</summary>
public partial class UMovieScene3DAttachSection : UMovieScene3DConstraintSection {
// MovieScene3DAttachSection
	public string AttachSocketName;
	public string AttachComponentName;
	public bool bFullRevertOnDetach;
	public TSoftObjectPtr<USceneComponent> ReAttachOnDetach;
	public EAttachmentRule AttachmentLocationRule;
	public EAttachmentRule AttachmentRotationRule;
	public EAttachmentRule AttachmentScaleRule;
	public EDetachmentRule DetachmentLocationRule;
	public EDetachmentRule DetachmentRotationRule;
	public EDetachmentRule DetachmentScaleRule;
}

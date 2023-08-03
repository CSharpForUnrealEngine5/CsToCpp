#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A 3D Attach section</summary>
[CppInclude("Sections/MovieScene3DAttachSection.h")]
public partial class UMovieScene3DAttachSection : UMovieScene3DConstraintSection {
	public static UClass StaticClass() {return default;}
	///<summary>AttachSocketName</summary>
	public string AttachSocketName;
	///<summary>AttachComponentName</summary>
	public string AttachComponentName;
	///<summary>bFullRevertOnDetach</summary>
	public bool bFullRevertOnDetach;
	///<summary>ReAttachOnDetach</summary>
	public TSoftObjectPtr<USceneComponent> ReAttachOnDetach;
	///<summary>AttachmentLocationRule</summary>
	public EAttachmentRule AttachmentLocationRule;
	///<summary>AttachmentRotationRule</summary>
	public EAttachmentRule AttachmentRotationRule;
	///<summary>AttachmentScaleRule</summary>
	public EAttachmentRule AttachmentScaleRule;
	///<summary>DetachmentLocationRule</summary>
	public EDetachmentRule DetachmentLocationRule;
	///<summary>DetachmentRotationRule</summary>
	public EDetachmentRule DetachmentRotationRule;
	///<summary>DetachmentScaleRule</summary>
	public EDetachmentRule DetachmentScaleRule;
}

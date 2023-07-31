#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/ControlRigSnapSettings.h")]
public partial class UControlRigSnapSettings : UObject {
	///<summary>When snapping keep offset, if false snap completely</summary>
	public bool bKeepOffset;
	///<summary>When snapping, also snap position</summary>
	public bool bSnapPosition;
	///<summary>When snapping, also snap rotation</summary>
	public bool bSnapRotation;
	///<summary>When snapping, also snap scale</summary>
	public bool bSnapScale;
}

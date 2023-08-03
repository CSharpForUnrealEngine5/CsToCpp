#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows you to place content with a desired size and have it scale to meet the constraints placed on this box&#39;s alloted area.  If</summary>
[CppInclude("Components/ScaleBox.h")]
public partial class UScaleBox : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The stretching rule to apply when content is stretched</summary>
	public EStretch Stretch;
	///<summary>Controls in what direction content can be scaled</summary>
	public EStretchDirection StretchDirection;
	///<summary>Optional scale that can be specified by the User. Used only for UserSpecified stretching.</summary>
	public float UserSpecifiedScale;
	///<summary>Optional bool to ignore the inherited scale. Applies inverse scaling to counteract parents before applying the local scale operation.</summary>
	public bool IgnoreInheritedScale;
	///<summary>SetStretch</summary>
	public  void SetStretch(EStretch InStretch) {}
	///<summary>SetStretchDirection</summary>
	public  void SetStretchDirection(EStretchDirection InStretchDirection) {}
	///<summary>SetUserSpecifiedScale</summary>
	public  void SetUserSpecifiedScale(float InUserSpecifiedScale) {}
	///<summary>SetIgnoreInheritedScale</summary>
	public  void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale) {}
}

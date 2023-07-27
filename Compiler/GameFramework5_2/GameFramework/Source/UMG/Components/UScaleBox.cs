#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ScaleBox.h")]
///<summary>Allows you to place content with a desired size and have it scale to meet the constraints placed on this box's alloted area.  If</summary>
public partial class UScaleBox : UContentWidget {
// ScaleBox
	public byte Stretch;
	public byte StretchDirection;
	public float UserSpecifiedScale;
	public bool IgnoreInheritedScale;
	public  void SetStretch(EStretch InStretch) {}
	public  void SetStretchDirection(EStretchDirection InStretchDirection) {}
	public  void SetUserSpecifiedScale(float InUserSpecifiedScale) {}
	public  void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale) {}
}

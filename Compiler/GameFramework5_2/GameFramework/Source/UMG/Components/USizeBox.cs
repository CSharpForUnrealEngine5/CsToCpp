#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SizeBox.h")]
///<summary>A widget that allows you to specify the size it reports to have and desire.  Not all widgets report a desired size</summary>
public partial class USizeBox : UContentWidget {
// SizeBox
	public float WidthOverride;
	public float HeightOverride;
	public float MinDesiredWidth;
	public float MinDesiredHeight;
	public float MaxDesiredWidth;
	public float MaxDesiredHeight;
	public float MinAspectRatio;
	public float MaxAspectRatio;
	public bool bOverride_WidthOverride;
	public bool bOverride_HeightOverride;
	public bool bOverride_MinDesiredWidth;
	public bool bOverride_MinDesiredHeight;
	public bool bOverride_MaxDesiredWidth;
	public bool bOverride_MaxDesiredHeight;
	public bool bOverride_MinAspectRatio;
	public bool bOverride_MaxAspectRatio;
	public void SetWidthOverride(float InWidthOverride) {}
	public void ClearWidthOverride() {}
	public void SetHeightOverride(float InHeightOverride) {}
	public void ClearHeightOverride() {}
	public void SetMinDesiredWidth(float InMinDesiredWidth) {}
	public void ClearMinDesiredWidth() {}
	public void SetMinDesiredHeight(float InMinDesiredHeight) {}
	public void ClearMinDesiredHeight() {}
	public void SetMaxDesiredWidth(float InMaxDesiredWidth) {}
	public void ClearMaxDesiredWidth() {}
	public void SetMaxDesiredHeight(float InMaxDesiredHeight) {}
	public void ClearMaxDesiredHeight() {}
	public void SetMinAspectRatio(float InMinAspectRatio) {}
	public void ClearMinAspectRatio() {}
	public void SetMaxAspectRatio(float InMaxAspectRatio) {}
	public void ClearMaxAspectRatio() {}
}

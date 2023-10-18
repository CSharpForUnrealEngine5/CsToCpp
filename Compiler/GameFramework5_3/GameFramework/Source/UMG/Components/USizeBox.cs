namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A widget that allows you to specify the size it reports to have and desire.  Not all widgets report a desired size</summary>
[CppInclude("Components/SizeBox.h")]
public partial class USizeBox : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>When specified, ignore the content&#39;s desired size and report the WidthOverride as the Box&#39;s desired width.</summary>
	public float WidthOverride;
	///<summary>When specified, ignore the content&#39;s desired size and report the HeightOverride as the Box&#39;s desired height.</summary>
	public float HeightOverride;
	///<summary>When specified, will report the MinDesiredWidth if larger than the content&#39;s desired width.</summary>
	public float MinDesiredWidth;
	///<summary>When specified, will report the MinDesiredHeight if larger than the content&#39;s desired height.</summary>
	public float MinDesiredHeight;
	///<summary>When specified, will report the MaxDesiredWidth if smaller than the content&#39;s desired width.</summary>
	public float MaxDesiredWidth;
	///<summary>When specified, will report the MaxDesiredHeight if smaller than the content&#39;s desired height.</summary>
	public float MaxDesiredHeight;
	///<summary>MinAspectRatio</summary>
	public float MinAspectRatio;
	///<summary>MaxAspectRatio</summary>
	public float MaxAspectRatio;
	///<summary>bOverride_WidthOverride</summary>
	public bool bOverride_WidthOverride;
	///<summary>bOverride_HeightOverride</summary>
	public bool bOverride_HeightOverride;
	///<summary>bOverride_MinDesiredWidth</summary>
	public bool bOverride_MinDesiredWidth;
	///<summary>bOverride_MinDesiredHeight</summary>
	public bool bOverride_MinDesiredHeight;
	///<summary>bOverride_MaxDesiredWidth</summary>
	public bool bOverride_MaxDesiredWidth;
	///<summary>bOverride_MaxDesiredHeight</summary>
	public bool bOverride_MaxDesiredHeight;
	///<summary>bOverride_MinAspectRatio</summary>
	public bool bOverride_MinAspectRatio;
	///<summary>bOverride_MaxAspectRatio</summary>
	public bool bOverride_MaxAspectRatio;
	///<summary>When specified, ignore the content&#39;s desired size and report the WidthOverride as the Box&#39;s desired width.</summary>
	public void SetWidthOverride(float InWidthOverride) {}
	///<summary>ClearWidthOverride</summary>
	public void ClearWidthOverride() {}
	///<summary>When specified, ignore the content&#39;s desired size and report the HeightOverride as the Box&#39;s desired height.</summary>
	public void SetHeightOverride(float InHeightOverride) {}
	///<summary>ClearHeightOverride</summary>
	public void ClearHeightOverride() {}
	///<summary>When specified, will report the MinDesiredWidth if larger than the content&#39;s desired width.</summary>
	public void SetMinDesiredWidth(float InMinDesiredWidth) {}
	///<summary>ClearMinDesiredWidth</summary>
	public void ClearMinDesiredWidth() {}
	///<summary>When specified, will report the MinDesiredHeight if larger than the content&#39;s desired height.</summary>
	public void SetMinDesiredHeight(float InMinDesiredHeight) {}
	///<summary>ClearMinDesiredHeight</summary>
	public void ClearMinDesiredHeight() {}
	///<summary>When specified, will report the MaxDesiredWidth if smaller than the content&#39;s desired width.</summary>
	public void SetMaxDesiredWidth(float InMaxDesiredWidth) {}
	///<summary>ClearMaxDesiredWidth</summary>
	public void ClearMaxDesiredWidth() {}
	///<summary>When specified, will report the MaxDesiredHeight if smaller than the content&#39;s desired height.</summary>
	public void SetMaxDesiredHeight(float InMaxDesiredHeight) {}
	///<summary>ClearMaxDesiredHeight</summary>
	public void ClearMaxDesiredHeight() {}
	///<summary>SetMinAspectRatio</summary>
	public void SetMinAspectRatio(float InMinAspectRatio) {}
	///<summary>ClearMinAspectRatio</summary>
	public void ClearMinAspectRatio() {}
	///<summary>SetMaxAspectRatio</summary>
	public void SetMaxAspectRatio(float InMaxAspectRatio) {}
	///<summary>ClearMaxAspectRatio</summary>
	public void ClearMaxAspectRatio() {}
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements an image center adjustment algorithm.</summary>
[CppInclude("Calibrators/CameraImageCenterAlgoManual.h")]
public partial class UCameraImageCenterAlgoManual : UCameraImageCenterAlgo {
	///<summary>Cached original image center that was evaluated at the current focus and zoom</summary>
	public FImageCenterInfo OriginalImageCenter;
	///<summary>Latest image center that may have been adjusted by manual user input</summary>
	public FImageCenterInfo AdjustedImageCenter;
}

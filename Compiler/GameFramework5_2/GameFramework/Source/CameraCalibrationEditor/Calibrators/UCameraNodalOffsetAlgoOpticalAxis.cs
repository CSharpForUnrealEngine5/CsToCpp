#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Calibrators/CameraNodalOffsetAlgoOpticalAxis.h")]
///<summary>Implements a nodal offset calibration algorithm that relies on the idea that the nodal point of the lens</summary>
public partial class UCameraNodalOffsetAlgoOpticalAxis : UCameraNodalOffsetAlgoPoints {
// CameraNodalOffsetAlgoOpticalAxis
	public FNodalPointOffset AdjustedNodalOffset;
	public FNodalPointOffset LastSavedNodalOffset;
	public float EntrancePupilPosition;
	public float LastSavedEntrancePupilPosition;
	public UTextureRenderTarget2D OverlayTexture;
}

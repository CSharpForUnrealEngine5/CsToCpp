#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a nodal offset calibration algorithm that relies on the idea that the nodal point of the lens</summary>
[CppInclude("Calibrators/CameraNodalOffsetAlgoOpticalAxis.h")]
public partial class UCameraNodalOffsetAlgoOpticalAxis : UCameraNodalOffsetAlgoPoints {
	public static UClass StaticClass() {return default;}
	///<summary>The current value of the nodal offset that has been written to the lens file, but not necessarily transacted</summary>
	public FNodalPointOffset AdjustedNodalOffset;
	///<summary>The last nodal offset to have been saved and transacted</summary>
	public FNodalPointOffset LastSavedNodalOffset;
	///<summary>The parametric position along the optical axis where the nodal points sits</summary>
	public float EntrancePupilPosition;
	///<summary>The last entrance pupil position to have been saved and transacted</summary>
	public float LastSavedEntrancePupilPosition;
	///<summary>Texture used to draw the crosshair overlay</summary>
	public UTextureRenderTarget2D OverlayTexture;
}

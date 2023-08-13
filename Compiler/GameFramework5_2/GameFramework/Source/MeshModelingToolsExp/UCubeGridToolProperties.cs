namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CubeGridTool.h")]
public partial class UCubeGridToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>GridFrameOrigin</summary>
	public FVector GridFrameOrigin;
	///<summary>GridFrameOrientation</summary>
	public FRotator GridFrameOrientation;
	///<summary>bShowGizmo</summary>
	public bool bShowGizmo;
	///<summary>Determines cube grid scale. Can also be adjusted with Ctrl + E/Q.</summary>
	public byte GridPower;
	///<summary>Sets the size of a block at the current grid power. This is done by changing the</summary>
	public double CurrentBlockSize;
	///<summary>How many blocks each push/pull invocation will do at a time.</summary>
	public int BlocksPerStep;
	///<summary>When true, block sizes change by powers of two as grid power is changed. When false, block</summary>
	public bool bPowerOfTwoBlockSizes;
	///<summary>Smallest block size to use in the grid. For instance, 3.125 results in</summary>
	public double BlockBaseSize;
	///<summary>When pushing/pulling in a way where the diagonal matters, setting this to true</summary>
	public bool bCrosswiseDiagonal;
	///<summary>When performing multiple push/pulls with the same selection, attempt to keep the</summary>
	public bool bKeepSideGroups;
	///<summary>When performing selection, the tolerance to use when determining</summary>
	public double PlaneTolerance;
	///<summary>When raycasting to find a selected grid face, this determines whether geometry</summary>
	public bool bHitUnrelatedGeometry;
	///<summary>When the grid ground plane is above some geometry, whether we should hit that</summary>
	public bool bHitGridGroundPlaneIfCloser;
	///<summary>How the selected face is determined.</summary>
	public ECubeGridToolFaceSelectionMode FaceSelectionMode;
	///<summary>ToggleCornerMode</summary>
	public string ToggleCornerMode;
	///<summary>PushPull</summary>
	public string PushPull;
	///<summary>ResizeGrid</summary>
	public string ResizeGrid;
	///<summary>SlideSelection</summary>
	public string SlideSelection;
	///<summary>FlipSelection</summary>
	public string FlipSelection;
	///<summary>GridGizmo</summary>
	public string GridGizmo;
	///<summary>QuickShiftGizmo</summary>
	public string QuickShiftGizmo;
	///<summary>AlignGizmo</summary>
	public string AlignGizmo;
	///<summary>bInCornerMode</summary>
	public bool bInCornerMode;
	///<summary>bAllowedToEditGrid</summary>
	public bool bAllowedToEditGrid;
}

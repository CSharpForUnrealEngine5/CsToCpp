#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PatternTool.h")]
///<summary>Settings for the Pattern Tool</summary>
public partial class UPatternToolSettings : UInteractiveToolPropertySet {
// PatternToolSettings
	public int Seed;
	public bool bProjectElementsDown;
	public float ProjectionOffset;
	public bool bHideSources;
	public bool bUseRelativeTransforms;
	public EPatternToolShape Shape;
	public EPatternToolSingleAxis SingleAxis;
	public EPatternToolSinglePlane SinglePlane;
}

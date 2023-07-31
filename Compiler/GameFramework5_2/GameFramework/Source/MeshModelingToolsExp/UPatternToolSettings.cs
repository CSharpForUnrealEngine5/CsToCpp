#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Pattern Tool</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternToolSettings : UInteractiveToolPropertySet {
	///<summary>The seed used to introduce random transform variations when enabled</summary>
	public int Seed;
	///<summary>Whether or not the pattern items should be projected along the negative Z axis of the plane mechanic</summary>
	public bool bProjectElementsDown;
	///<summary>How much each pattern item should be moved along the negative Z axis of the plane mechanic if Project Elements Down is enabled</summary>
	public float ProjectionOffset;
	///<summary>Hide the source meshes when enabled</summary>
	public bool bHideSources;
	///<summary>If false, all pattern elements will be positioned at the origin of the first pattern element</summary>
	public bool bUseRelativeTransforms;
	///<summary>Shape of the underlying Pattern</summary>
	public EPatternToolShape Shape;
	///<summary>Axis direction used for the Pattern geometry</summary>
	public EPatternToolSingleAxis SingleAxis;
	///<summary>Plane used for the Pattern geometry</summary>
	public EPatternToolSinglePlane SinglePlane;
}

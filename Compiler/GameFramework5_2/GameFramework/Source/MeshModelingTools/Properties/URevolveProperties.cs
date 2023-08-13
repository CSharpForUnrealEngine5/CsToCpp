namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Common properties for revolving a PolyPath to create a mesh.</summary>
[CppInclude("Properties/RevolveProperties.h")]
public partial class URevolveProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Revolution extent in degrees. Clamped to a maximum of 360 if Height Offset Per Degree is set to 0.</summary>
	public double RevolveDegreesClamped;
	///<summary>Revolution extent in degrees. Clamped to a maximum of 360 if Height Offset Per Degree is set to 0.</summary>
	public double RevolveDegrees;
	///<summary>The angle by which to rotate the path around the axis before beginning the revolve.</summary>
	public double RevolveDegreesOffset;
	///<summary>Implicitly defines the number of steps in the revolution such that each step moves the revolution no more than the given number of degrees. This is only available if Explicit Steps is disabled.</summary>
	public double StepsMaxDegrees;
	///<summary>If true, the number of steps can be specified explicitly via Steps. If false, the number of steps is adjusted automatically based on Steps Max Degrees.</summary>
	public bool bExplicitSteps;
	///<summary>Number of steps in the revolution. This is only available if Explicit Steps is enabled.</summary>
	public int NumExplicitSteps;
	///<summary>How far to move each step along the revolution axis per degree. Non-zero values are useful for creating spirals.</summary>
	public double HeightOffsetPerDegree;
	///<summary>By default, revolution is done counterclockwise if looking down the revolution axis. This reverses the revolution direction to clockwise.</summary>
	public bool bReverseRevolutionDirection;
	///<summary>Flips the mesh inside out.</summary>
	public bool bFlipMesh;
	///<summary>If true, normals are not averaged or shared between triangles beyond the Sharp Normals Degree Threshold.</summary>
	public bool bSharpNormals;
	///<summary>The threshold in degrees beyond which normals are not averaged or shared between triangles anymore. This is only available if Sharp Normals is enabled.</summary>
	public double SharpNormalsDegreeThreshold;
	///<summary>If true, the path is placed at the midpoint of each step instead of at the start and/or end of a step. For example, this is useful for creating square columns.</summary>
	public bool bPathAtMidpointOfStep;
	///<summary>How PolyGroups are assigned to shape primitives. If caps are generated, they will always be in separate groups.</summary>
	public ERevolvePropertiesPolygroupMode PolygroupMode;
	///<summary>How generated quads are split into triangles.</summary>
	public ERevolvePropertiesQuadSplit QuadSplitMode;
}

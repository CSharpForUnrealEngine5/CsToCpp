#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSculptToolBase.h")]
public partial class USculptMaxBrushProperties : UInteractiveToolPropertySet {
	///<summary>Specify maximum displacement height (relative to brush size)</summary>
	public float MaxHeight;
	///<summary>Use maximum height from last brush stroke, regardless of brush size. Note that spatial brush falloff still applies.</summary>
	public bool bFreezeCurrentHeight;
}

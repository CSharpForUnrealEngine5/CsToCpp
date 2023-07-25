#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapePatchComponent.h")]
///<summary>Used to store some extra data during RerunConstructionScripts, namely the component's position in the patch manager.</summary>
public partial struct FLandscapePatchComponentInstanceData {
// LandscapePatchComponentInstanceData
	public int IndexInManager;
	public bool bGaveMissingPatchManagerWarning;
	public bool bGaveNotInPatchManagerWarning;
	public bool bGaveMissingLandscapeWarning;
}

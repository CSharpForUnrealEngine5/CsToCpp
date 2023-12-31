namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to store some extra data during RerunConstructionScripts, namely the component&#39;s position in the patch manager.</summary>
[CppInclude("LandscapePatchComponent.h")]
public partial struct FLandscapePatchComponentInstanceData {
	public int IndexInManager;
	public bool bGaveMissingPatchManagerWarning;
	public bool bGaveNotInPatchManagerWarning;
	public bool bGaveMissingLandscapeWarning;
}

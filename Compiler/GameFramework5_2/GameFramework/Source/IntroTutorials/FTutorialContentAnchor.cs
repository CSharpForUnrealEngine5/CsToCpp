#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTutorial.h")]
///<summary>A way of identifying something to be highlighted by a tutorial</summary>
public partial struct FTutorialContentAnchor {
// TutorialContentAnchor
	public ETutorialAnchorIdentifier Type;
	public string WrapperIdentifier;
	public FSoftObjectPath Asset;
	public bool bDrawHighlight;
	public string TabToFocusOrOpen;
	public string FriendlyName;
	public string GUIDString;
	public string OuterName;
}

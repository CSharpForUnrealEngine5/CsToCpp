namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A way of identifying something to be highlighted by a tutorial</summary>
[CppInclude("EditorTutorial.h")]
public partial struct FTutorialContentAnchor {
	public ETutorialAnchorIdentifier Type;
	public string WrapperIdentifier;
	public FSoftObjectPath Asset;
	public bool bDrawHighlight;
	public string TabToFocusOrOpen;
	public string FriendlyName;
	public string GUIDString;
	public string OuterName;
}

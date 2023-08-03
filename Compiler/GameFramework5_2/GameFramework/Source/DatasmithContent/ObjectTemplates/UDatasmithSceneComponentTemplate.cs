#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithSceneComponentTemplate.h")]
public partial class UDatasmithSceneComponentTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>RelativeTransform</summary>
	public FTransform RelativeTransform;
	///<summary>Mobility</summary>
	public EComponentMobility Mobility;
	///<summary>AttachParent</summary>
	public TSoftObjectPtr<USceneComponent> AttachParent;
	///<summary>bVisible</summary>
	public bool bVisible;
	///<summary>bCastShadow</summary>
	public bool bCastShadow;
	///<summary>Tags</summary>
	public TSet<string> Tags;
}

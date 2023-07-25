#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithSceneComponentTemplate.h")]
public partial class UDatasmithSceneComponentTemplate : UDatasmithObjectTemplate {
// DatasmithSceneComponentTemplate
	public FTransform RelativeTransform;
	public byte Mobility;
	public TSoftObjectPtr<USceneComponent> AttachParent;
	public bool bVisible;
	public bool bCastShadow;
	public TSet<string> Tags;
}

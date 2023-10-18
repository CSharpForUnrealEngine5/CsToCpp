namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows you to expose an external slot for your user widget.  When others reuse your user control,</summary>
[CppInclude("Components/NamedSlot.h")]
public partial class UNamedSlot : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Named slots exposed on the instance only follow a slightly different set of rules.  For example, they can contain</summary>
	public bool bExposeOnInstanceOnly;
	///<summary>SlotGuid</summary>
	public FGuid SlotGuid;
}

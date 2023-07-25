#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/NamedSlot.h")]
///<summary>Allows you to expose an external slot for your user widget.  When others reuse your user control,</summary>
public partial class UNamedSlot : UContentWidget {
// NamedSlot
	public bool bExposeOnInstanceOnly;
	public FGuid SlotGuid;
}

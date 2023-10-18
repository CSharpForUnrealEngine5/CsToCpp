namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/EditorNotifyObject.h")]
public partial class UEditorNotifyObject : UEditorAnimBaseObj {
	public static UClass StaticClass() {return default;}
	///<summary>The notify event to modify</summary>
	public FAnimNotifyEvent Event;
}

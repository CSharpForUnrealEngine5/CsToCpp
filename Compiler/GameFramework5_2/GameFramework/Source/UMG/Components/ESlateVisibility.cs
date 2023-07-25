#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SlateWrapperTypes.h")]
///<summary>Is an entity visible?</summary>
public enum ESlateVisibility {
	Visible=0,
	Collapsed=1,
	Hidden=2,
	HitTestInvisible=3,
	SelfHitTestInvisible=4,
}

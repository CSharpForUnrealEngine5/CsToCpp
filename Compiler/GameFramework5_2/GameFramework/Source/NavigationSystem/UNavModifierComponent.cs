#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavModifierComponent.h")]
public partial class UNavModifierComponent : UNavRelevantComponent {
	public static UClass StaticClass() {return default;}
	///<summary>AreaClass</summary>
	public UClass AreaClass;
	///<summary>box extent used ONLY when owning actor doesn&#39;t have collision component</summary>
	public FVector FailsafeExtent;
	///<summary>Setting to &#39;true&#39; will result in expanding lower bounding box of the nav</summary>
	public bool bIncludeAgentHeight;
	///<summary>SetAreaClass</summary>
	public  void SetAreaClass(UClass NewAreaClass) {}
}

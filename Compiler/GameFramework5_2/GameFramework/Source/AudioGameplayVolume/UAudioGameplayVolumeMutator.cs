#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioGameplayVolumeMutator - These components are used for more complex interactions with AudioGameplayVolumes.</summary>
[CppInclude("AudioGameplayVolumeMutator.h")]
public partial class UAudioGameplayVolumeMutator : UAudioGameplayComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SetPriority</summary>
	public  void SetPriority(int InPriority) {}
	///<summary>The priority of this component.  In the case of overlapping volumes or multiple affecting components, the highest priority is chosen.</summary>
	public int Priority;
}

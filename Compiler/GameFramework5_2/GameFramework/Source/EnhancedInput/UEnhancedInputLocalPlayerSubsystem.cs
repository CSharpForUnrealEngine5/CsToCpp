#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per local player input subsystem</summary>
[CppInclude("EnhancedInputSubsystems.h")]
public partial class UEnhancedInputLocalPlayerSubsystem : ULocalPlayerSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>A delegate that will be called when control mappings have been rebuilt this frame.</summary>
	public  void FOnControlMappingsRebuilt() {}
	///<summary>Blueprint Event that is called at the end of any frame that Control Mappings have been rebuilt.</summary>
	public FOnControlMappingsRebuilt ControlMappingsRebuiltDelegate;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Processor that monitors when entities change lane and notify the MassCrowd subsystem.</summary>
[CppInclude("MassCrowdNavigationProcessor.h")]
public partial class UMassCrowdLaneTrackingSignalProcessor : UMassSignalProcessorBase {
	public static UClass StaticClass() {return default;}
}

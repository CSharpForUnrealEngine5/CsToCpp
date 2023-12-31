namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceCamera.h")]
public partial class UNiagaraDataInterfaceCamera : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>This is used to determine which camera position to query for cpu emitters. If no valid index is supplied, the first controller is used as camera reference.</summary>
	public int PlayerControllerIndex;
	///<summary>When this option is disabled, we use the previous frame&#39;s data for the camera and issue the simulation early. This greatly</summary>
	public bool bRequireCurrentFrameData;
}

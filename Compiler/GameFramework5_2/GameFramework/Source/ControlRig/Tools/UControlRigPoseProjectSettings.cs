namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/ControlRigPoseProjectSettings.h")]
public partial class UControlRigPoseProjectSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The root of the directory in which to save poses</summary>
	public TArray<FDirectoryPath> RootSaveDirs;
}

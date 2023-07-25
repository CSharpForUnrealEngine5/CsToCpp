#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCompiler/RigVMCompiler.h")]
public partial struct FRigVMCompileSettings {
// RigVMCompileSettings
	public bool SurpressInfoMessages;
	public bool SurpressWarnings;
	public bool SurpressErrors;
	public bool EnablePinWatches;
	public bool IsPreprocessorPhase;
	public FRigVMParserASTSettings ASTSettings;
	public bool SetupNodeInstructionIndex;
}

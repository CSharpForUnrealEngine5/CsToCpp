namespace GameFramework;
using CSharpToCpp.Utilities;

[CppInclude("Engine/EngineBaseTypes.h")]
public partial struct FActorTickFunction
{
    public bool bTickEvenWhenPaused;
    public bool bStartWithTickEnabled;
    public bool bCanEverTick;
    public float TickInterval;

    public void SetTickFunctionEnable(bool bInEnabled) { }
    public bool IsTickFunctionEnabled() { return false; }
}

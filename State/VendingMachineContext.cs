namespace State;

public class VendingMachineContext {
    private IVendingMachineState _state = null!;

    public void SetState(IVendingMachineState state) {
        _state = state;
    }

    public void Request() {
        _state.HandleRequest();
    }
}
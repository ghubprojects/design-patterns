namespace State;

public class ReadyState : IVendingMachineState {
    public void HandleRequest() {
        Console.WriteLine("Ready state: Please select a product.");
    }
}
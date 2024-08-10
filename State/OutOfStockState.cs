namespace State;

public class OutOfStockState : IVendingMachineState {
    public void HandleRequest() {
        Console.WriteLine("Out of stock state: Product unavailable. Please select another product.");
    }
}
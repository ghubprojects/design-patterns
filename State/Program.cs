using State;

var vendingMachine = new VendingMachineContext();

vendingMachine.SetState(new ReadyState());
vendingMachine.Request();

vendingMachine.SetState(new ProductSelectedState());
vendingMachine.Request();

vendingMachine.SetState(new PaymentPendingState());
vendingMachine.Request();

vendingMachine.SetState(new OutOfStockState());
vendingMachine.Request();
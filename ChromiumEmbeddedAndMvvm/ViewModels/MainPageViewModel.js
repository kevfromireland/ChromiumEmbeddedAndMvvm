function MainPageViewModel() {
    var self = this;

    self.AlertOsVersionInfoClicked = function () {
        alert(AppServices.GetHostOsVersion());
    };

    self.DisplayCallStack = function () {
        AppServices.DisplayCallStack();
    };

    self.BreakIntoVsDebugger = function () {
        AppServices.BreakIntoDebugger();
    };
}

ko.applyBindings(new MainPageViewModel());
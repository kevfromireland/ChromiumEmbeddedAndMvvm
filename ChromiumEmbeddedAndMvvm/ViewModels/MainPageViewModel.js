function MainPageViewModel() {
    var self = this;

    self.AlertOsVersionInfoClicked = function () {
        alert(AppServices.GetHostOsVersion());
    };

    self.DisplayCallStack = function () {
        AppServices.DisplayCallStack();
    };
}

ko.applyBindings(new MainPageViewModel());
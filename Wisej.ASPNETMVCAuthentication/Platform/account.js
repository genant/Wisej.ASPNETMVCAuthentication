qx.Class.define("qx.datev.Account", {
    extend: qx.core.Object,
    construct: function () { /* ... */ },
    statics: {
        logOff: function () {
            /* sends a request to the account controller to logout the user */
            var req = new qx.io.request.Xhr('/Account/SignOut');
            req.addListener('success', App.Page1.LogoutSuccess(), this);
            req.send();
        },
        checkLogin: function () {
            /* sends a request to the account controller to logout the user */
            var req = new qx.io.request.Xhr('/Account/CheckLogin');
            req.addListener('success', function (e) {
                window.location = "/Account/Login";
            }, this);
            req.send();
        }
    }
});
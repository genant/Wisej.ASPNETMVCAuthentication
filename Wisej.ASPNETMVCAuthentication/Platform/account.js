﻿qx.Class.define("qx.datev.Account", {
    extend: qx.core.Object,
    construct: function () { /* ... */ },
    statics: {
        logOff: function (uri) {
            /* sends a request to the account controller to logout the user */
            var req = new qx.io.request.Xhr(uri);
            req.addListener('success', App.Page1.LogoutSuccess(), this);
            req.send();
        }
    }
});